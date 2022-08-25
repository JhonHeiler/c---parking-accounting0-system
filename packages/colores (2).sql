-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-08-2021 a las 12:55:16
-- Versión del servidor: 10.4.14-MariaDB
-- Versión de PHP: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `colores`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `cedula` varchar(50) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `celular` varchar(50) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `dia_pago` varchar(10) DEFAULT NULL,
  `ref_pago` varchar(50) DEFAULT NULL,
  `comentario` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingreso`
--

CREATE TABLE `ingreso` (
  `fecha` datetime NOT NULL,
  `hora` varchar(10) NOT NULL,
  `placa` varchar(50) NOT NULL,
  `vehiculo` varchar(50) DEFAULT NULL,
  `usuario` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingreso_lavado`
--

CREATE TABLE `ingreso_lavado` (
  `placa` varchar(50) NOT NULL,
  `encargado` varchar(50) NOT NULL,
  `identificacion` varchar(50) NOT NULL,
  `vehiculo` varchar(50) NOT NULL,
  `fecha` datetime NOT NULL,
  `total` double NOT NULL,
  `tipo_lavado` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lavador`
--

CREATE TABLE `lavador` (
  `fecha` datetime NOT NULL,
  `hora` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `identificacion` double NOT NULL,
  `valor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensualidades`
--

CREATE TABLE `mensualidades` (
  `Id_ventas` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `hora` varchar(20) NOT NULL,
  `placa` varchar(10) DEFAULT NULL,
  `egresos` int(11) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `mes` varchar(50) DEFAULT NULL,
  `servicio` varchar(50) DEFAULT NULL,
  `cliente` varchar(50) DEFAULT NULL,
  `usuario` varchar(50) DEFAULT NULL,
  `valor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `id_pagos` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `hora` varchar(45) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `identificacion` double NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamo`
--

CREATE TABLE `prestamo` (
  `nombre` varchar(45) NOT NULL,
  `cedula` double NOT NULL,
  `valor` double NOT NULL,
  `fecha` date NOT NULL,
  `hora` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `temporal_ingreso`
--

CREATE TABLE `temporal_ingreso` (
  `fecha` datetime NOT NULL,
  `hora` varchar(10) NOT NULL,
  `placa` varchar(50) DEFAULT NULL,
  `vehiculo` varchar(50) DEFAULT NULL,
  `usuario` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `total_ventas`
--

CREATE TABLE `total_ventas` (
  `fechadesde` datetime NOT NULL,
  `fechahasta` datetime NOT NULL,
  `total` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id_user` int(11) NOT NULL,
  `nombre_user` varchar(50) DEFAULT NULL,
  `contraseña_user` varchar(50) DEFAULT NULL,
  `cargo_user` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id_user`, `nombre_user`, `contraseña_user`, `cargo_user`) VALUES
(7633479, 'Administrador', 'localjardin1', 'Admi');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculo_pendientes`
--

CREATE TABLE `vehiculo_pendientes` (
  `fecha` datetime NOT NULL,
  `hora` varchar(20) NOT NULL,
  `lavador` varchar(50) NOT NULL,
  `placa` varchar(50) NOT NULL,
  `vehiculo` varchar(50) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `valor` double NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `Id_ventas` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `hora` varchar(20) NOT NULL,
  `placa` varchar(10) DEFAULT NULL,
  `egresos` int(11) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `mes` varchar(50) DEFAULT NULL,
  `servicio` varchar(50) DEFAULT NULL,
  `cliente` varchar(50) DEFAULT NULL,
  `usuario` varchar(50) DEFAULT NULL,
  `valor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`Id_ventas`, `fecha`, `hora`, `placa`, `egresos`, `tipo`, `mes`, `servicio`, `cliente`, `usuario`, `valor`) VALUES
(0, '2021-08-04 00:00:00', '17:25', 'prueba', 0, 'pruba', 'marzo', 'arriendo', 'heiler', 'ADMINISTRADOR', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `lavador`
--
ALTER TABLE `lavador`
  ADD UNIQUE KEY `identificacion` (`identificacion`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`id_pagos`);

--
-- Indices de la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD UNIQUE KEY `cedula` (`cedula`);

--
-- Indices de la tabla `vehiculo_pendientes`
--
ALTER TABLE `vehiculo_pendientes`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `id_pagos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `vehiculo_pendientes`
--
ALTER TABLE `vehiculo_pendientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
