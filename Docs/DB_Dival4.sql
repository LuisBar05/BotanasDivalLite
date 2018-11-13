-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema DB_Dival
-- -----------------------------------------------------
-- Esquema de Base de Datos para Botanas, Frituras y Garapiñados "Dival".
-- Last edited: 19/05/2018

-- -----------------------------------------------------
-- Schema DB_Dival
--
-- Esquema de Base de Datos para Botanas, Frituras y Garapiñados "Dival".
-- Last edited: 19/05/2018
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `DB_Dival` DEFAULT CHARACTER SET utf8 ;
USE `DB_Dival` ;

-- -----------------------------------------------------
-- Table `DB_Dival`.`status`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`status` (
  `Id_Status` INT(2) NOT NULL AUTO_INCREMENT,
  `Status` VARCHAR(1) NOT NULL,
  `Descripcion_Status` VARCHAR(25) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Status`),
  UNIQUE INDEX `Id_Status` (`Id_Status` ASC),
  UNIQUE INDEX `Status` (`Status` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`unidades_medida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`unidades_medida` (
  `Id_UniMed` INT(2) NOT NULL AUTO_INCREMENT,
  `Descripcion_UniMed` VARCHAR(25) NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL,
  PRIMARY KEY (`Id_UniMed`),
  UNIQUE INDEX `Id_UniMed_UNIQUE` (`Id_UniMed` ASC),
  INDEX `fk_UniMed_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_UniMed_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`presentaciones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`presentaciones` (
  `Id_Presentacion` INT(3) NOT NULL AUTO_INCREMENT,
  `Cantidad` FLOAT NOT NULL,
  `Id_UniMed` INT(2) NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Presentacion`),
  UNIQUE INDEX `Id_Presentación_UNIQUE` (`Id_Presentacion` ASC),
  INDEX `fk_Present_UniMed_idx` (`Id_UniMed` ASC),
  INDEX `fk_Present_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_Present_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Present_UniMed`
    FOREIGN KEY (`Id_UniMed`)
    REFERENCES `DB_Dival`.`unidades_medida` (`Id_UniMed`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`categorias` (
  `Id_Categoria` INT(3) NOT NULL AUTO_INCREMENT,
  `Nombre_Categoria` VARCHAR(20) NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Categoria`),
  UNIQUE INDEX `Id_Categoría_UNIQUE` (`Id_Categoria` ASC),
  INDEX `fk_Categ_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_Categ_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`recetas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`recetas` (
  `Id_Receta` INT(10) NOT NULL AUTO_INCREMENT,
  `Id_Categoria` INT(3) NOT NULL,
  `Descripcion` VARCHAR(50) NOT NULL,
  `Merma` FLOAT NULL,
  `Id_UniMed` INT(2) NOT NULL,
  `Costo_Kilo` FLOAT NOT NULL DEFAULT 0,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Receta`),
  UNIQUE INDEX `Id_Receta_UNIQUE` (`Id_Receta` ASC),
  INDEX `fk_Rece_Categ_idx` (`Id_Categoria` ASC),
  INDEX `fk_Recet_Status_idx` (`Status` ASC),
  INDEX `fk_Recer_UniMed_idx` (`Id_UniMed` ASC),
  CONSTRAINT `fk_Receta_UniMed`
    FOREIGN KEY (`Id_UniMed`)
    REFERENCES `DB_Dival`.`unidades_medida` (`Id_UniMed`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Receta_Categorias`
    FOREIGN KEY (`Id_Categoria`)
    REFERENCES `DB_Dival`.`categorias` (`Id_Categoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Receta_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`productos` (
  `Id_Producto` INT(10) NOT NULL AUTO_INCREMENT,
  `Cod_Producto` VARCHAR(8) NOT NULL,
  `Descripcion` VARCHAR(50) NOT NULL,
  `Id_Receta` INT(10) NOT NULL,
  `Id_Presentacion` INT(3) NOT NULL,
  `Precio` FLOAT NOT NULL,
  `Costo_Unit` FLOAT NOT NULL DEFAULT 0,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Producto`, `Cod_Producto`),
  UNIQUE INDEX `Id_Producto_UNIQUE` (`Id_Producto` ASC),
  UNIQUE INDEX `Cod_Producto_UNIQUE` (`Cod_Producto` ASC),
  INDEX `fk_Prod_Rece_idx` (`Id_Receta` ASC),
  INDEX `fk_Product_Presentaciones` (`Id_Presentacion` ASC),
  INDEX `fk_Product_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_Product_Presentaciones`
    FOREIGN KEY (`Id_Presentacion`)
    REFERENCES `DB_Dival`.`presentaciones` (`Id_Presentacion`),
  CONSTRAINT `fk_Product_Recetas`
    FOREIGN KEY (`Id_Receta`)
    REFERENCES `DB_Dival`.`recetas` (`Id_Receta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Product_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`inventario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`inventario` (
  `Id_Inventario` INT(10) NOT NULL AUTO_INCREMENT,
  `Fecha_Registro` DATE NOT NULL,
  `Cod_Producto` VARCHAR(8) NOT NULL,
  `Cantidad` INT(5) NOT NULL,
  `Fecha_Elaboracion` DATE NOT NULL,
  `Fecha_Caducidad` DATE NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Inventario`),
  UNIQUE INDEX `Id_Almacén_UNIQUE` (`Id_Inventario` ASC),
  INDEX `fk_Almac_Status_idx` (`Status` ASC),
  INDEX `fk_Invent_Prod_idx` (`Cod_Producto` ASC),
  CONSTRAINT `fk_Invent_Productos`
    FOREIGN KEY (`Cod_Producto`)
    REFERENCES `DB_Dival`.`productos` (`Cod_Producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Invent_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`compras`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`compras` (
  `Id_Compra` INT(10) NOT NULL AUTO_INCREMENT,
  `Total_Compra` FLOAT NOT NULL,
  `Fecha_Compra` DATE NOT NULL,
  `Lugar_Compra` VARCHAR(50) NULL DEFAULT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Compra`),
  UNIQUE INDEX `Id_Compra_UNIQUE` (`Id_Compra` ASC),
  INDEX `fk_Comp_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_Comp_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`ingredientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`ingredientes` (
  `Id_Ingrediente` INT(10) NOT NULL AUTO_INCREMENT,
  `Nombre_Ingrediente` VARCHAR(45) NOT NULL,
  `Cantidad` FLOAT NOT NULL,
  `Id_UniMed` INT(2) NOT NULL,
  `Precio_Compra` FLOAT NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Ingrediente`),
  INDEX `fk_Ingred_UniMed_idx` (`Id_UniMed` ASC),
  INDEX `fk_Ingred_Status_idx` (`Status` ASC),
  UNIQUE INDEX `Id_Ingrediente_UNIQUE` (`Id_Ingrediente` ASC),
  CONSTRAINT `fk_Ingred_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ingred_UniMed`
    FOREIGN KEY (`Id_UniMed`)
    REFERENCES `DB_Dival`.`unidades_medida` (`Id_UniMed`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`detalle_compra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`detalle_compra` (
  `Id_DetCompra` INT(10) NOT NULL AUTO_INCREMENT,
  `Id_Compra` INT(10) NOT NULL,
  `Id_Ingrediente` INT(10) NOT NULL,
  `Cantidad` FLOAT NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_DetCompra`),
  UNIQUE INDEX `Id_DetCompra_UNIQUE` (`Id_DetCompra` ASC),
  INDEX `fk_DetComp_Comp_idx` (`Id_Compra` ASC),
  INDEX `fk_DetComp_Ingred_idx` (`Id_Ingrediente` ASC),
  INDEX `fk_DetComp_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_DetComp_Compras`
    FOREIGN KEY (`Id_Compra`)
    REFERENCES `DB_Dival`.`compras` (`Id_Compra`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetComp_Ingredientes`
    FOREIGN KEY (`Id_Ingrediente`)
    REFERENCES `DB_Dival`.`ingredientes` (`Id_Ingrediente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetComp_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`ventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`ventas` (
  `Id_Venta` INT(10) NOT NULL AUTO_INCREMENT,
  `Total_Venta` FLOAT NOT NULL,
  `Fecha_Venta` DATE NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Venta`),
  UNIQUE INDEX `Id_Vta_UNIQUE` (`Id_Venta` ASC),
  INDEX `fk_Vta_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_Vent_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`detalle_venta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`detalle_venta` (
  `Id_DetVenta` INT(10) NOT NULL AUTO_INCREMENT,
  `Id_Venta` INT(10) NOT NULL,
  `Cod_Producto` VARCHAR(8) NOT NULL,
  `Cantidad` INT(4) NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_DetVenta`),
  UNIQUE INDEX `Id_DVta_UNIQUE` (`Id_DetVenta` ASC),
  INDEX `fk_Vent_Fact_idx` (`Id_Venta` ASC),
  INDEX `fk_DetVta_Status_idx` (`Status` ASC),
  INDEX `fk_DetVta_Prod_idx` (`Cod_Producto` ASC),
  CONSTRAINT `fk_DetVent_Productos`
    FOREIGN KEY (`Cod_Producto`)
    REFERENCES `DB_Dival`.`productos` (`Cod_Producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetVent_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetVent_Venta`
    FOREIGN KEY (`Id_Venta`)
    REFERENCES `DB_Dival`.`ventas` (`Id_Venta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`almacen`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`almacen` (
  `Id_Almacen` INT(10) NOT NULL AUTO_INCREMENT,
  `Id_Ingrediente` INT(10) NOT NULL,
  `Cantidad` INT(5) NOT NULL,
  `Fecha_Caducidad` DATE NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Almacen`),
  UNIQUE INDEX `Id_Inventario_UNIQUE` (`Id_Almacen` ASC),
  INDEX `fk_Invent_Status_idx` (`Status` ASC),
  INDEX `fk_Almac_Ingred_idx` (`Id_Ingrediente` ASC),
  CONSTRAINT `fk_Almac_Ingredientes`
    FOREIGN KEY (`Id_Ingrediente`)
    REFERENCES `DB_Dival`.`ingredientes` (`Id_Ingrediente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Almac_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `DB_Dival`.`listas_ingredientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`listas_ingredientes` (
  `Id_ListasIngred` INT(10) NOT NULL AUTO_INCREMENT,
  `Id_Receta` INT(10) NOT NULL,
  `Id_Ingrediente` INT(10) NOT NULL,
  `Cantidad` FLOAT NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL,
  PRIMARY KEY (`Id_ListasIngred`),
  UNIQUE INDEX `Id_ListasIngred_UNIQUE` (`Id_ListasIngred` ASC),
  INDEX `fk_ListIngred_Ingred_idx` (`Id_Ingrediente` ASC),
  INDEX `fk_ListIngred_Rece_idx` (`Id_Receta` ASC),
  INDEX `fk_ListIngred_Status_idx` (`Status` ASC),
  CONSTRAINT `fk_ListIngred_Ingredientes`
    FOREIGN KEY (`Id_Ingrediente`)
    REFERENCES `DB_Dival`.`ingredientes` (`Id_Ingrediente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ListIngred_Recetas`
    FOREIGN KEY (`Id_Receta`)
    REFERENCES `DB_Dival`.`recetas` (`Id_Receta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ListIngred_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_Dival`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`pedidos` (
  `Id_Pedido` INT(10) NOT NULL,
  `Cliente` VARCHAR(50) NOT NULL,
  `Total_Pedido` FLOAT NOT NULL,
  `Fecha_Pedido` DATE NOT NULL,
  `Fecha_Entrega` DATE NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL,
  PRIMARY KEY (`Id_Pedido`),
  UNIQUE INDEX `Id_Pedidos_UNIQUE` (`Id_Pedido` ASC),
  INDEX `fk_pedidos_status1_idx` (`Status` ASC),
  CONSTRAINT `fk_Pedi_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_Dival`.`detalle_pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_Dival`.`detalle_pedido` (
  `Id_DetPedido` INT(10) NOT NULL,
  `Id_Pedido` INT(10) NOT NULL,
  `Cod_Producto` VARCHAR(8) NOT NULL,
  `Cantidad` INT(4) NOT NULL,
  `Status` VARCHAR(1) NOT NULL,
  `Observaciones` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Id_DetPedido`),
  UNIQUE INDEX `Id_DetPedido_UNIQUE` (`Id_DetPedido` ASC),
  INDEX `fk_detalle_pedido_status1_idx` (`Status` ASC),
  INDEX `fk_detalle_pedido_pedidos1_idx` (`Id_Pedido` ASC),
  INDEX `fk_detalle_pedido_productos1_idx` (`Cod_Producto` ASC),
  CONSTRAINT `fk_DetPedido_Status`
    FOREIGN KEY (`Status`)
    REFERENCES `DB_Dival`.`status` (`Status`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetPedido_Pedidos`
    FOREIGN KEY (`Id_Pedido`)
    REFERENCES `DB_Dival`.`pedidos` (`Id_Pedido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_DetPedido_Productos`
    FOREIGN KEY (`Cod_Producto`)
    REFERENCES `DB_Dival`.`productos` (`Cod_Producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
