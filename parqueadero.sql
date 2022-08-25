-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 08-08-2021 a las 22:41:12
-- Versión del servidor: 10.4.19-MariaDB
-- Versión de PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `parqueadero`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_facturas`
--

CREATE TABLE `usuarios_facturas` (
  `id` bigint(20) NOT NULL,
  `valor` bigint(20) NOT NULL,
  `fecha_pago` date DEFAULT NULL,
  `servicio_id` bigint(20) NOT NULL,
  `usuario_id` bigint(20) NOT NULL,
  `vehiculo_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_facturas_usuario_parq`
--

CREATE TABLE `usuarios_facturas_usuario_parq` (
  `id` bigint(20) NOT NULL,
  `facturas_id` bigint(20) NOT NULL,
  `usuarios_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_ingresos_salidas`
--

CREATE TABLE `usuarios_ingresos_salidas` (
  `id` bigint(20) NOT NULL,
  `hora_inicio` time(6) DEFAULT NULL,
  `hora_final` time(6) DEFAULT NULL,
  `fecha_ingreso` date DEFAULT NULL,
  `fecha_salida` date DEFAULT NULL,
  `servicio_id` bigint(20) NOT NULL,
  `vehiculo_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_ingresos_salidas`
--

INSERT INTO `usuarios_ingresos_salidas` (`id`, `hora_inicio`, `hora_final`, `fecha_ingreso`, `fecha_salida`, `servicio_id`, `vehiculo_id`) VALUES
(1, '20:37:32.000000', '06:00:00.000000', '2021-08-08', '2021-08-13', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_planes`
--

CREATE TABLE `usuarios_planes` (
  `id` bigint(20) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL,
  `valor` bigint(20) NOT NULL,
  `servicio_id` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_planes`
--

INSERT INTO `usuarios_planes` (`id`, `nombre`, `valor`, `servicio_id`) VALUES
(1, 'Mensualidad', 130000, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_planuser`
--

CREATE TABLE `usuarios_planuser` (
  `id` bigint(20) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_final` date NOT NULL,
  `plan_id` bigint(20) NOT NULL,
  `usuario_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_planuser`
--

INSERT INTO `usuarios_planuser` (`id`, `fecha_inicio`, `fecha_final`, `plan_id`, `usuario_id`) VALUES
(1, '2021-08-08', '2021-09-30', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_rol`
--

CREATE TABLE `usuarios_rol` (
  `id` bigint(20) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_rol`
--

INSERT INTO `usuarios_rol` (`id`, `nombre`) VALUES
(1, 'Cliente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_servicios`
--

CREATE TABLE `usuarios_servicios` (
  `id` bigint(20) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL,
  `tipo_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_servicios`
--

INSERT INTO `usuarios_servicios` (`id`, `nombre`, `tipo_id`) VALUES
(1, 'Sencillo', 1),
(2, 'Parqueo', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_tiposervicio`
--

CREATE TABLE `usuarios_tiposervicio` (
  `id` bigint(20) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_tiposervicio`
--

INSERT INTO `usuarios_tiposervicio` (`id`, `nombre`) VALUES
(1, 'Lavado'),
(2, 'Parqueadero');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_tipovehiculo`
--

CREATE TABLE `usuarios_tipovehiculo` (
  `id` bigint(20) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_tipovehiculo`
--

INSERT INTO `usuarios_tipovehiculo` (`id`, `nombre`) VALUES
(1, 'moto');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_usuarios`
--

CREATE TABLE `usuarios_usuarios` (
  `id` bigint(20) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `apellido` varchar(200) NOT NULL,
  `genero` varchar(200) DEFAULT NULL,
  `clave` varchar(200) NOT NULL,
  `rol_id` bigint(20) NOT NULL,
  `identificacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_usuarios`
--

INSERT INTO `usuarios_usuarios` (`id`, `nombre`, `apellido`, `genero`, `clave`, `rol_id`, `identificacion`) VALUES
(1, 'Jhon', 'harlinton', '123', '12343', 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_vehiculousuario`
--

CREATE TABLE `usuarios_vehiculousuario` (
  `id` bigint(20) NOT NULL,
  `placa` varchar(100) DEFAULT NULL,
  `modelo` varchar(100) DEFAULT NULL,
  `tipovehiculo_id` bigint(20) NOT NULL,
  `usuario_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios_vehiculousuario`
--

INSERT INTO `usuarios_vehiculousuario` (`id`, `placa`, `modelo`, `tipovehiculo_id`, `usuario_id`) VALUES
(1, 'MX23D', '2017', 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `usuarios_facturas`
--
ALTER TABLE `usuarios_facturas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_facturas_servicio_id_c8560456_fk_usuarios_servicios_id` (`servicio_id`),
  ADD KEY `usuarios_facturas_usuario_id_8b255d3d_fk_usuarios_usuarios_id` (`usuario_id`),
  ADD KEY `usuarios_facturas_vehiculo_id_ff4e7ea5_fk_usuarios_` (`vehiculo_id`);

--
-- Indices de la tabla `usuarios_facturas_usuario_parq`
--
ALTER TABLE `usuarios_facturas_usuario_parq`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `usuarios_facturas_usuari_facturas_id_usuarios_id_d9ec7039_uniq` (`facturas_id`,`usuarios_id`),
  ADD KEY `usuarios_facturas_us_usuarios_id_d4283c41_fk_usuarios_` (`usuarios_id`);

--
-- Indices de la tabla `usuarios_ingresos_salidas`
--
ALTER TABLE `usuarios_ingresos_salidas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_ingresos_sa_servicio_id_23ad5b3d_fk_usuarios_` (`servicio_id`),
  ADD KEY `usuarios_ingresos_sa_vehiculo_id_2ff4cd28_fk_usuarios_` (`vehiculo_id`);

--
-- Indices de la tabla `usuarios_planes`
--
ALTER TABLE `usuarios_planes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_planes_servicio_id_b1fb01d0_fk_usuarios_servicios_id` (`servicio_id`);

--
-- Indices de la tabla `usuarios_planuser`
--
ALTER TABLE `usuarios_planuser`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_planuser_plan_id_ace3006d_fk_usuarios_planes_id` (`plan_id`),
  ADD KEY `usuarios_planuser_usuario_id_1509eff0_fk_usuarios_usuarios_id` (`usuario_id`);

--
-- Indices de la tabla `usuarios_rol`
--
ALTER TABLE `usuarios_rol`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios_servicios`
--
ALTER TABLE `usuarios_servicios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_servicios_tipo_id_fd7a00fa_fk_usuarios_tiposervicio_id` (`tipo_id`);

--
-- Indices de la tabla `usuarios_tiposervicio`
--
ALTER TABLE `usuarios_tiposervicio`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios_tipovehiculo`
--
ALTER TABLE `usuarios_tipovehiculo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios_usuarios`
--
ALTER TABLE `usuarios_usuarios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_usuarios_rol_id_120e55eb_fk_usuarios_rol_id` (`rol_id`);

--
-- Indices de la tabla `usuarios_vehiculousuario`
--
ALTER TABLE `usuarios_vehiculousuario`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_vehiculousu_tipovehiculo_id_3d469288_fk_usuarios_` (`tipovehiculo_id`),
  ADD KEY `usuarios_vehiculousu_usuario_id_185d7634_fk_usuarios_` (`usuario_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `usuarios_facturas`
--
ALTER TABLE `usuarios_facturas`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios_facturas_usuario_parq`
--
ALTER TABLE `usuarios_facturas_usuario_parq`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios_ingresos_salidas`
--
ALTER TABLE `usuarios_ingresos_salidas`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios_planes`
--
ALTER TABLE `usuarios_planes`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios_planuser`
--
ALTER TABLE `usuarios_planuser`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios_rol`
--
ALTER TABLE `usuarios_rol`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios_servicios`
--
ALTER TABLE `usuarios_servicios`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `usuarios_tiposervicio`
--
ALTER TABLE `usuarios_tiposervicio`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `usuarios_tipovehiculo`
--
ALTER TABLE `usuarios_tipovehiculo`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios_usuarios`
--
ALTER TABLE `usuarios_usuarios`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios_vehiculousuario`
--
ALTER TABLE `usuarios_vehiculousuario`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `usuarios_facturas`
--
ALTER TABLE `usuarios_facturas`
  ADD CONSTRAINT `usuarios_facturas_servicio_id_c8560456_fk_usuarios_servicios_id` FOREIGN KEY (`servicio_id`) REFERENCES `usuarios_servicios` (`id`),
  ADD CONSTRAINT `usuarios_facturas_usuario_id_8b255d3d_fk_usuarios_usuarios_id` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios_usuarios` (`id`),
  ADD CONSTRAINT `usuarios_facturas_vehiculo_id_ff4e7ea5_fk_usuarios_` FOREIGN KEY (`vehiculo_id`) REFERENCES `usuarios_vehiculousuario` (`id`);

--
-- Filtros para la tabla `usuarios_facturas_usuario_parq`
--
ALTER TABLE `usuarios_facturas_usuario_parq`
  ADD CONSTRAINT `usuarios_facturas_us_facturas_id_7909286f_fk_usuarios_` FOREIGN KEY (`facturas_id`) REFERENCES `usuarios_facturas` (`id`),
  ADD CONSTRAINT `usuarios_facturas_us_usuarios_id_d4283c41_fk_usuarios_` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios_usuarios` (`id`);

--
-- Filtros para la tabla `usuarios_ingresos_salidas`
--
ALTER TABLE `usuarios_ingresos_salidas`
  ADD CONSTRAINT `usuarios_ingresos_sa_servicio_id_23ad5b3d_fk_usuarios_` FOREIGN KEY (`servicio_id`) REFERENCES `usuarios_servicios` (`id`),
  ADD CONSTRAINT `usuarios_ingresos_sa_vehiculo_id_2ff4cd28_fk_usuarios_` FOREIGN KEY (`vehiculo_id`) REFERENCES `usuarios_vehiculousuario` (`id`);

--
-- Filtros para la tabla `usuarios_planes`
--
ALTER TABLE `usuarios_planes`
  ADD CONSTRAINT `usuarios_planes_servicio_id_b1fb01d0_fk_usuarios_servicios_id` FOREIGN KEY (`servicio_id`) REFERENCES `usuarios_servicios` (`id`);

--
-- Filtros para la tabla `usuarios_planuser`
--
ALTER TABLE `usuarios_planuser`
  ADD CONSTRAINT `usuarios_planuser_plan_id_ace3006d_fk_usuarios_planes_id` FOREIGN KEY (`plan_id`) REFERENCES `usuarios_planes` (`id`),
  ADD CONSTRAINT `usuarios_planuser_usuario_id_1509eff0_fk_usuarios_usuarios_id` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios_usuarios` (`id`);

--
-- Filtros para la tabla `usuarios_servicios`
--
ALTER TABLE `usuarios_servicios`
  ADD CONSTRAINT `usuarios_servicios_tipo_id_fd7a00fa_fk_usuarios_tiposervicio_id` FOREIGN KEY (`tipo_id`) REFERENCES `usuarios_tiposervicio` (`id`);

--
-- Filtros para la tabla `usuarios_usuarios`
--
ALTER TABLE `usuarios_usuarios`
  ADD CONSTRAINT `usuarios_usuarios_rol_id_120e55eb_fk_usuarios_rol_id` FOREIGN KEY (`rol_id`) REFERENCES `usuarios_rol` (`id`);

--
-- Filtros para la tabla `usuarios_vehiculousuario`
--
ALTER TABLE `usuarios_vehiculousuario`
  ADD CONSTRAINT `usuarios_vehiculousu_tipovehiculo_id_3d469288_fk_usuarios_` FOREIGN KEY (`tipovehiculo_id`) REFERENCES `usuarios_tipovehiculo` (`id`),
  ADD CONSTRAINT `usuarios_vehiculousu_usuario_id_185d7634_fk_usuarios_` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios_usuarios` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
