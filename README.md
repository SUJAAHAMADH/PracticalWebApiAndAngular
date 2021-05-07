# PracticalWebApiAndAngular
# Here I have used .net core 3.1 version to create web api
# Angular 7 version for Front End Application
Used Factory Design Pattern approach in the .net core web api to load data based on the request from the user

Steps to run web Api project
-----------------------------
You need .net core 3.1 version to build the api project

Open the web api project in VS 2019 and build the application

Run the application get started in your local machine. You can notice it will run in localhost(https://localhost:44387)

Overview of Web Api Project Structure
-----------------------------
Api project contains Controller folder which contains all the controllers for http requests.

Service folder contains service interfaces and implemented classes.

Factory folder contains TemperatureFactory class for the application.

You need to register factory class, Iservices and service classes in startup.cs -->void ConfigureServices(IServiceCollection services) method.

Eg.

 ```C#
services.AddScoped<TemperatureFactory>();
            services.AddScoped<FahrenheitToOtherTempService>()
               .AddScoped<ITemperatureService, FahrenheitToOtherTempService>(s => s.GetService<FahrenheitToOtherTempService>());
 ```
            
Since we are using Angular as frontend application we need to allow the external request to access the api.

To do that we need to allow cors origin policy

Add--> 
```c#
services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
                 .AllowAnyHeader());
            });
  ```
  under --> startup.cs -->void ConfigureServices(IServiceCollection services) method.
  
  Then add --> 
  ```c#
  app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
  ```
  under--> startup.cs -->void Configure(IApplicationBuilder app, IWebHostEnvironment env) method.
  
  Running Angular Project
  ---------------------------
  Open Angular project in a suitable IDE you have installed.
  
  I have used VS code to open Angular project.
  
  To installed npm modules which is included in package.json
  
  --> You need to open new terminal in vs code
  
  --> run the command 'npm install' if you are using yarn commands run 'yarn' in the terminal
  
 Once all the npm modules are installed successfully run 'ng serve' or 'npm start' command to up your Angular application.
 
  Overview of Angular Project
  ---------------------------
  You can see component Temperatureconversiondetail.Component.ts,TemperatureconversiondetailComponent.html and css for that file inside component folder.
  
  service to retrive data from web api project is written inside service->converter.service.ts file.
  
  You need to register your components inside app.module.ts
  
   If you use 'ng g c components/temperatureconversiondetail' command it will automatically create Temperatureconversiondetail.Component.ts file and it will              automatically added to app.module.ts
   
   Similary you can create service classes using 
   ``` ng g s <serviceName>```
            
  eg: for this project service run 'ng g s services/converter' which will create a service folder and create a converter.service.ts file inside it.
  
  Similarly for models you can use 'ng g class models/tutorial --type=model' command to create model classes inside a model folder.
  
  
  


