CREATE TABLE `person` (
	`id` BIGINT(19) NOT NULL AUTO_INCREMENT,
	`address` VARCHAR(100) NOT NULL COLLATE 'latin1_swedish_ci',
	`first_name` VARCHAR(80) NOT NULL COLLATE 'latin1_swedish_ci',
	`gender` VARCHAR(6) NOT NULL COLLATE 'latin1_swedish_ci',
	`last_name` VARCHAR(80) NOT NULL COLLATE 'latin1_swedish_ci',
	PRIMARY KEY (`id`) USING BTREE
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB
;