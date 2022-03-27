
  CREATE TABLE "SYSTEM"."FACTURAS" 
   (	"IDFACTURA" NUMBER NOT NULL ENABLE, 
	"NUMEROFACTURA" VARCHAR2(20 BYTE) NOT NULL ENABLE, 
	"FECHA" TIMESTAMP (6) NOT NULL ENABLE, 
	"TIPODEPAGO" VARCHAR2(20 BYTE) NOT NULL ENABLE, 
	"DOCUMENTOCLIENTE" VARCHAR2(20 BYTE) NOT NULL ENABLE, 
	"NOMBRECLIENTE" VARCHAR2(100 BYTE) NOT NULL ENABLE, 
	"SUBTOTAL" NUMBER(*,0), 
	"DESCUENTO" NUMBER(*,0), 
	"IVA" NUMBER(*,0), 
	"TOTALDESCUENTO" NUMBER(*,0), 
	"TOTALIMPUESTO" NUMBER(*,0), 
	"TOTAL" NUMBER(*,0), 
	 CONSTRAINT "FACTURAS_PK" PRIMARY KEY ("IDFACTURA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "SYSTEM"."FACTURAS_TRG" 
  BEFORE INSERT ON  "SYSTEM"."FACTURAS" FOR EACH ROW
  WHEN (new.IDFACTURA is null) begin
SELECT FACTURA_SEQUENCE.NEXTVAL
  INTO :new.IDFACTURA
  FROM dual;
END;
/
ALTER TRIGGER "SYSTEM"."FACTURAS_TRG" ENABLE;

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "SYSTEM"."FACTURA_TRG" 
  BEFORE INSERT ON  "SYSTEM"."FACTURAS" FOR EACH ROW
  WHEN (new.IDFACTURA is null) begin
SELECT FACTURA_SEQUENCE.NEXTVAL
  INTO :new.IDFACTURA
  FROM dual;
END;
/
ALTER TRIGGER "SYSTEM"."FACTURA_TRG" DISABLE;




CREATE TABLE "SYSTEM"."FACTURASPRODUCTO" 
   (	"FACTURAID" NUMBER NOT NULL ENABLE, 
	"PRODUCTOID" NUMBER NOT NULL ENABLE, 
	 CONSTRAINT "FACTURAPRODUCTO_PK" PRIMARY KEY ("FACTURAID", "PRODUCTOID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;



  CREATE TABLE "SYSTEM"."PRODUCTOS" 
   (	"IDPRODUCTO" NUMBER NOT NULL ENABLE, 
	"PRODUCTO" VARCHAR2(500 BYTE), 
	 CONSTRAINT "PRODUCTOS_PK" PRIMARY KEY ("IDPRODUCTO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "SYSTEM"."PRODUCTOS_TRG" 
  BEFORE INSERT ON  "SYSTEM"."PRODUCTOS" FOR EACH ROW
  WHEN (new.IDPRODUCTO is null) begin
SELECT PRODUCTO_SEQUENCE.NEXTVAL
  INTO :new.IDPRODUCTO
  FROM dual;
END;
/
ALTER TRIGGER "SYSTEM"."PRODUCTOS_TRG" ENABLE;
