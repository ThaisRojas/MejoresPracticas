# Proyecto .NET Core: Vehículos (Refactorizado con Patrones y SOLID)

Este proyecto implementa una arquitectura MVC robusta aplicando principios de diseño de software para garantizar escalabilidad y mantenibilidad.

## Patrones de Diseño Aplicados
1. *Repository Pattern:* Abstrae la lógica de persistencia de datos mediante `IVehicleRepository`, permitiendo desacoplar el controlador de la capa de datos.
2. *Singleton Pattern:* Utilizado en `VehicleCollection` para garantizar una única instancia de la lista de vehículos en memoria durante todo el ciclo de vida de la aplicación.

## Principios SOLID Aplicados
1. *Single Responsibility (SRP):* Se ha delegado la gestión de datos al repositorio, permitiendo que el `HomeController` solo se encargue de manejar las peticiones HTTP y devolver las vistas.
2. *Dependency Inversion (DIP):* El controlador depende de abstracciones (`IVehicleRepository`), permitiendo inyectar dependencias y facilitar futuras pruebas unitarias.

## Enlaces de entrega
- *Proyecto Deployado:* 
- *Video de Evidencia:* 
- *GitHub:* https://github.com/ThaisRojas/MejoresPracticas.git 