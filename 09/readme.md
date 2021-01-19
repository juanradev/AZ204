## AZ-204: DEVELOPING SOLUTIONS FOR MICROSOFT AZURE


### Lab: Creating a multi-tier solution by using services in Azure

---


[Intrucciones](https://microsoftlearning.github.io/AZ-204-DevelopingSolutionsforMicrosoftAzure/Instructions/Labs/AZ-204_09_lab_ak.html)

----


#### Exercise 1: Implement a workflow using Logic Apps

Task 2: Create an API Management resource

Name:  prodapimjrdf01  
Name: AutomatedWorkflow   
Pricing tier: __Consumption (99.9 SLA, %)__  


Task 3: Create a Logic App resource

Name:  prodflowjrdf   
Resource Group: AutomatedWorkflow    
Log Analytics: Off.  

Task 4: Create a storage account

Name: prodstorjrdf  
Performance: Standard.  
In the Replication list, select Locally-redundant storage (LRS).  
In the Access tier (default) section, ensure that Hot is selected.  


![Recursos](imagenes/c1.PNG)


Task 5: Upload sample content to Azure Files

FileShared name: metadata
Cuota: 1 GB

![FileShared](imagenes/c2.PNG)


![Upload Files](imagenes/c3.PNG)




----



#### Exercise 2: Implement a workflow using Logic Apps


Task 1: Create a trigger for the workflow

Abrimos el workflow:


![Blank Logic App](imagenes/c4.PNG)


seleccionamos el trigger HttpRequest


![HttpRequest](imagenes/c5.PNG)

![When a HTTP request is received](imagenes/c6.PNG)

y le agregamos el metodo Get

![Get](imagenes/c7.PNG)

Task 2: Create an action to query Azure Storage file shares


Nuevo Paso y seleccionamos 

![Azure Storage file shares](imagenes/c8.PNG)

![List Files](imagenes/c9.PNG)

Y le ponemos nuestra cuenta de almacenamiento y la carpeta

![cuenta de almacenamiento](imagenes/c10.PNG)

![carpeta](imagenes/c11.PNG)

Task 3: Create an action to project list item properties


El siguiente paso es un Data Operations 

![carpeta](imagenes/c12.PNG)

![select](imagenes/c13.PNG)



Task 4: Build an HTTP response action

Ojo que todo es por contenido dinamico

![select](imagenes/c14.PNG)

![select](imagenes/c15.PNG)

![select](imagenes/c16.PNG)

![select](imagenes/c18.PNG)

![select](imagenes/c19.PNG)

deberia quedar así

![finnal](imagenes/c20.PNG)


####  Exercise 3: Use Azure API Management as a proxy for Logic Apps

Task 1: Create an API integrated with Logic Apps


En el APi Mannagent añadimos una nueva API Logic APp

![API Logic APp](imagenes/c21.PNG)


Task 2: Test the API operation


![select](imagenes/c22.PNG)

#### Exercise 4: Clean up your subscription


```

az group delete --name AutomatedWorkflow --no-wait --yes

```