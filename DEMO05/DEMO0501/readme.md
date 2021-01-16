## AZ-204: DEVELOPING SOLUTIONS FOR MICROSOFT AZURE

### 05: CREATE AND DEPLOY ARM TEMPLATES

#### Demo: Create ARM templates by using the Azure Portal

----

1. Vamos a guardar una plantilla y sus parametros a partir de Azure

2. Vamos a cargar un fichero de plantilla y un fichero de parametros para crear el recurso

----





En Azure creamos una nueva plantilla de storage account

Para ello iniciamos la creación de una cuenta de almacenamiento damos a revisar y crear, pero en vez de pulsar a CREAR, presionamos 

![c1](imagenes/c1.PNG)

Eso nos abre el editor de palantillas , revisa la pantalla,

![c1](imagenes/c2.PNG)

 y presionamos a Download, nos desgarga un zip con dos json Template y Parameters.

![c1](imagenes/c3.PNG)




Azure Portal se puede usar para realizar algunas ediciones básicas de plantillas mediante una herramienta de portal llamada Implementación de plantillas. Para editar una plantilla más compleja, considere utilizar Visual Studio Code, que proporciona funcionalidades de edición más completas.


![c1](imagenes/c6.PNG)


Ahora vamos a hacer el proceso inverso tenemos un tempalte.json y un parameters.json,

Bien pues creamos una nueva Template desde Azure


![c1](imagenes/c4.PNG)

vamos a crear su propia plantilla en el editor.

![c1](imagenes/c5.PNG)



![c1](imagenes/c7.PNG)

cargamos el archivo de templates 

![c1](imagenes/c8.PNG)

![c1](imagenes/c9.PNG)

y salvamos

una vez salvada tenemos la plantilla sin parametros, pues pues pulsamos editar parametros

![c1](imagenes/c10.PNG)

y cargamos el archivo parameters.json

![c1](imagenes/c12.PNG)

y guardamos

ya tenemos nuestra plantillda completa 

![c1](imagenes/c13.PNG)


le metemos la subscripcion y el grupo de recursos damos y creamos 


![c1](imagenes/c14.PNG)


![c1](imagenes/c15.PNG)

y ya tenemos el recurso creado

![c1](imagenes/c16.PNG)

Finalmente acuerate de eliminar los recursos si ya no los vas a utilizar

![c1](imagenes/c17.PNG)