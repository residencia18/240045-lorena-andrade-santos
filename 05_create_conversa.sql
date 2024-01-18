CREATE TABLE IF NOT EXISTS `mydb`.`conversa` (
  `idmensagem` INT NOT NULL,
  `data_hora_inicio` VARCHAR(45) NULL,
  `remetente_id_usuario` INT NOT NULL,
  `destinatario_id_usuario1` INT NOT NULL,
  PRIMARY KEY (`idmensagem`))
ENGINE = InnoDB;