# Taller de Arquitectura y Patrones de Diseño: Aplicativo de Automóviles

## Descripción del Proyecto
Este repositorio contiene la resolución de un taller práctico enfocado en la refactorización de un aplicativo web para la gestión de vehículos. El objetivo principal del proyecto fue solucionar problemas de arquitectura heredados, aislar dependencias externas (como bases de datos no finalizadas) y preparar el código para futuras expansiones del negocio utilizando buenas prácticas de Ingeniería de Software y principios SOLID.

## Patrones de Diseño Implementados

Para cumplir con los requerimientos técnicos y de la unidad de negocio, se refactorizó el código original implementando los siguientes patrones:

### 1. In-Memory Repository (con Singleton)
* **El Problema:** El aplicativo dependía de una base de datos cuyo esquema aún no estaba listo, bloqueando las pruebas funcionales del equipo de QA.
* **La Solución:** Se creó una colección en memoria (`MemoryCollection`) centralizada y administrada mediante un repositorio abstracto (`IVehicleRepository`). Esto permite probar toda la lógica de negocio (creación, encendido de motor, recarga de combustible) sin depender de infraestructura externa temporalmente.

### 2. Factory Method
* **El Problema:** La introducción de nuevos modelos de vehículos requería modificar directamente el código del controlador, violando el principio de Abierto/Cerrado (OCP).
* **La Solución:** Se delegó la instanciación de objetos a fábricas especializadas (`CarFactory`, `FordEscapeFactory`, etc.). Ahora el sistema soporta la incorporación de la familia de vehículos (Mustang, Explorer y Escape) de forma estandarizada y altamente escalable.

### 3. Builder Pattern
* **El Problema:** El equipo de negocio solicitó incluir el año actual y preparar la estructura para incorporar 20 propiedades por defecto adicionales en el próximo sprint, lo que amenazaba con generar constructores monolíticos ("Telescopic Constructors").
* **La Solución:** Se implementó `CarBuilder` para construir los vehículos paso a paso de forma fluida. El ensamblaje de propiedades por defecto quedó encapsulado, manteniendo las clases de los modelos limpias y cumpliendo con el principio de Responsabilidad Única (SRP).

## Tecnologías Utilizadas
* **Lenguaje:** C#
* **Framework:** ASP.NET Core MVC
* **Arquitectura:** Principios SOLID y Patrones de Diseño GoF.

## Cómo ejecutar el proyecto localmente

1. Clonar este repositorio.
2. Abrir una terminal en la carpeta raíz del proyecto (`DesignPatterns`).
3. Asegurarse de confiar en los certificados de desarrollo local de .NET:
   ```bash
   dotnet dev-certs https --trust
   ```

   Ejecutar el aplicativo:

```Bash
dotnet run
```
Abrir el navegador web en la dirección segura generada por Kestrel (usualmente https://localhost:5001).

Autor: Ricardo Herrera
