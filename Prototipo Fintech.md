# Prototipo Fintech

**Jose Miguel Chaves Miranda**

**Andres Aguilar Masis**

**Daniel Hernandez Sanchez**

## Mockups

![](media/62111ae64aa5c2a6c8d33a2c5be2b5f8.png)

![](media/007906aeb7ff86de9031936cc8ed2739.png)

![](media/0ced33715ecffab46af2fa173c170e63.png)

![](media/1018adcf4d9f08b025fa4e444b36b20b.png)

![](media/82f5974d2ee388e0c9e3588526fd9b91.png)

![](media/332da278677ec7244d79fb66fad3fee7.png)

![](media/c90faf369a6563e1550064c6282bf6ea.png)

![](media/6ad8e4830491f8d1f2b17c7918564bef.png)

![](media/63d616bb8080920068d825682a73cfdb.png)

![](media/3402d1a96a04d0035d80edf3b511243b.png)

![](media/4b6577f49a855d1eaf682dab1276ee1c.png)

![](media/d3b3bae8efa0232822dc2972a224737c.png)

![](media/e3a4a01061791ee5ebd1c4d042243a3c.png)

## CASO DE USO

![](media/934a9fe07981c24c836a65111c1c37f7.png)

## RED

![](media/1037c1ec5108cb2554416e135fa1979e.png)

## Seguridad

![](media/e94ff356884fbf8555ba4fab7767082f.png)

## Diagrama de Secuencia

![](media/68e6a6f2cd74e83444897b442f11e53c.png)

## Diagrama de Clases

![Imagen que contiene texto Descripción generada automáticamente](media/c58ab8fca6129864392c9fdbb9154f04.png)

## Diagrama de Objetos

![Imagen que contiene texto Descripción generada automáticamente](media/9bfca0134c35f08a021c9858e3a20ad2.png)

## NRAF

| **Tipo de Servicio**             | **IP de Fuente** | **IP de Destino** | **Puerto** | **Tipo de Trafico** | **TCP / UDP** |
|----------------------------------|------------------|-------------------|------------|---------------------|---------------|
| Correo                           | 192.168.0.1      | 192.168.0.16      | 443        | Bidireccional       | TCP           |
| Correo                           | 192.168.0.16     | 192.168.0.1       | 443        | Bidireccional       | TCP           |
| Base de datos                    | 192.168.0.1      | 192.168.0.16      | 3306       | Bidireccional       | TCP           |
| Base de datos                    | 192.168.0.16     | 192.168.0.1       | 3306       | Bidireccional       | TCP           |
| Tipo de Cambio del Banco Central | 192.168.0.16     | 192.168.0.1       | 80         | Unidireccional      | UDP           |
| Transacciones                    | 192.168.0.1      | 192.168.0.16      | 2049       | Bidireccional       | TCP           |
| Transacciones                    | 192.168.0.16     | 192.168.0.1       | 2049       | Bidireccional       | TCP           |
| Validacion Cliente               | 192.168.0.1      | 192.168.0.16      | 1812       | Bidireccional       | TCP           |
| Validacion Cliente               | 192.168.0.16     | 192.168.0.1       | 1812       | Bidireccional       | TCP           |
| Cuentas de Cliente               | 192.168.0.16     | 192.168.0.1       | 80         | Unidireccional      | UDP           |
| Fondo de Pensiones               | 192.168.0.16     | 192.168.0.1       | 80         | Unidireccional      | UDP           |
| Consulta de Saldos               | 192.168.0.16     | 192.168.0.1       | 80         | Unidireccional      | UDP           |
| Pagos                            | 192.168.0.1      | 192.168.0.16      | 443        | unidireccional      | TCP           |
| vpn                              | 192.168.0.1      | 192.168.0.16      | 51871      | unidireccional      | UDP           |
| autenticacion                    | 192.168.0.16     | 192.168.0.1       | 1812       | Bidireccional       | TCP           |
| autenticacion                    | 192.168.0.1      | 192.168.0.16      | 1812       | Bidireccional       | TCP           |
| Movimiento de cuentas            | 192.168.0.16     | 192.168.0.1       | 443        | Bidireccional       | TCP           |
| Movimiento de cuentas            | 192.168.0.1      | 192.168.0.16      | 443        | Bidireccional       | TCP           |
| Estado de cuenta                 | 192.168.0.16     | 192.168.0.1       | 443        | Bidireccional       | TCP           |
| Estado de cuenta                 | 192.168.0.1      | 192.168.0.16      | 443        | Bidireccional       | TCP           |
| transferencias al exterior       | 192.168.0.1      | 192.168.0.16      | 443        | unidireccional      | TCP           |
| cheques                          | 192.168.0.1      | 192.168.0.16      | 443        | unidireccional      | TCP           |
| Servidor Host                    | 192.168.0.1      | 192.168.0.16      | 2082       | Bidireccional       | TCP           |
| Servidor Host                    | 192.168.0.16     | 192.168.0.1       | 2082       | Bidireccional       | TCP           |
