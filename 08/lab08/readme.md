## AZ-204: DEVELOPING SOLUTIONS FOR MICROSOFT AZURE


### Lab: Creating a multi-tier solution by using services in Azure



#### Exercise 1: Creating an Azure App Service resource by using a Docker container image


----

Creamos los recursos
web app con una aplicacion docker 
api mannagent con la api creada
añadimos operaciones y polítcas

---- 


Task : Create a web app by using Azure App Service resource by using an httpbin container image

Basic Tab:
==========
Grupo de recursos: ApiService   
Nombre: httpapijrdf  
Publish: Docker  
So: Linix  
Location: la más cercana
ApPlan: ApiPlanjrdf  
Sku: por defecto

Docker Tab:
===========
Options: Single Container.  
Image Source: select Docker Hub.  
Access Type: Public.  
Image: kennethreitz/httpbin:latest 


![create web app](imagenes/c1.PNG)




Task : Test the httpbin web application  Es simplemente hacer un Browse y probar el GET (si falla verificar [en ContainerSettings Image: Kennethreitz/httpbin:latest](imagenes/c4.PNG)   


Pero bueno no fallo ;·)

![test](imagenes/c3.PNG)

fijate en el valor de Request URL 



Finalmente copiate esa url porque la vamos a necesitar

![url](imagenes/c5.PNG)


#### Exercise 2: Build an API proxy tier by using Azure API Management


Task: Create an API Management resource


Basic Tab:
==========
Grupo de recursos: ApiService   
Nombre: prodapikrdf  

Location: la más cercana

Organization name: la que más te guste
Administrator email: un mail válido si quieres
Pricing tier : Consumption (99.9 SLA, %)   !ESTO ES IMPORTANTE PARA QUE EL TIEMPO DE IMPLEMNTACION SEA CORTO!!! (si no tardará más de 40 ')


![API Management](imagenes/c6.PNG)

Vamos al recurso y añadimos una nueva API de tipo  __Blank API__

![ADD API  Blank API](imagenes/c7.PNG)


DisplayName: HTTPBin API  
name: httpbin-api  
Web service URL: la url que hemos copiado de httpapijrdf


![Create API  Blank API](imagenes/c8.PNG)


Vale ya está creada 

Añadimos Operación

![add Operation](imagenes/c10.PNG)


DisplayName: Echo Headers  
Name: echo headers  
URL GET   /

Añadimos Inbound processing

![add Operation](imagenes/c11.PNG)


Name:source  
value: zure-api-mgmt  
action: append  

![add Operation](imagenes/c12.PNG)


Editamos el Backend

![Backend](imagenes/c13.PNG)


y sobreescrimios el service url añadiendo /headers

![Backend](imagenes/c14.PNG)



Task 3: Manipulate an API response

Añadimos otra nueva operación


DisplayName:Get Legacy Data   
Name: get-legacy-data   
URL GET   /xml  

![Get Legacy Data ](imagenes/c15.PNG)


y le añadimos outbound policy Other policies 

![Add policy](imagenes/c16.PNG)


modificamos el xml

```xml
<policies>
    <inbound>
        <base />
    </inbound>
    <backend>
        <base />
    </backend>
    <outbound>
        <base />
        <xml-to-json kind="direct" apply="always" consider-accept-header="false" />
    </outbound>
    <on-error>
        <base />
    </on-error>
</policies>
```


Finalmente testeamos

[TEST](imagenes/c19.PNG)

[TEST](imagenes/c18.PNG)


Para rematar nos eliminaos el recurso desde Powershel

[TEST](imagenes/c20.PNG)
