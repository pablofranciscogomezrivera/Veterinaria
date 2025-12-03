# 🐾 Sistema de Gestión Veterinaria

Una aplicación web moderna y completa desarrollada en **.NET 8 (Blazor Server)** para la gestión administrativa y clínica de una veterinaria. El sistema permite administrar clientes, pacientes (mascotas) y sus historias clínicas, integrándose con servicios externos para agilizar la carga de datos.

## 🚀 Características Principales

### 👤 Gestión de Clientes (Dueños)
* **Integración con RENAPER:** Autocompletado de datos personales (Nombre, DNI, Domicilio) ingresando solo el CUIL, consumiendo una API externa.
* **Validaciones Inteligentes:** Prevención de registros duplicados y verificación de datos en tiempo real.
* **CRUD Completo:** Listado moderno con avatares, búsqueda y edición de datos de contacto (Email/Teléfono).

### 🐾 Gestión de Pacientes (Mascotas)
* Registro de mascotas vinculadas a un dueño.
* Soporte para múltiples especies (Perros, Gatos, Exóticos, etc.).
* Visualización rápida de mascotas desde el listado de clientes.

### 📋 Historia Clínica y Atenciones
* **Registro de Atenciones:** Cobro de consultas, vacunaciones, cirugías, etc.
* **Timeline Clínico:** Vista cronológica de la historia médica de cada mascota.
* **Perfil de Mascota:** Ficha técnica con edad calculada automáticamente y resumen de datos.

### 🎨 Experiencia de Usuario (UX/UI)
* **Diseño Responsivo:** Interfaz moderna construida con **Bootstrap 5**.
* **Feedback Visual:** Notificaciones flotantes (*Toasts*) para acciones exitosas o errores.
* **Indicadores de Carga:** Spinners automáticos para bloquear la pantalla durante peticiones asíncronas.

---

## 🛠️ Tecnologías Utilizadas

* **Framework:** .NET 8 (Blazor Server Side).
* **ORM:** Entity Framework Core 8.
* **Base de Datos:** SQL Server.
* **Estilos:** CSS3, Bootstrap 5, Bootstrap Icons.
* **Librerías Adicionales:**
    * `Blazored.Toast` (Notificaciones).
    * `Microsoft.EntityFrameworkCore.SqlServer`.
* **Arquitectura:** Inyección de Dependencias con uso de Interfaces (`IOwnerService`, `IMascotaService`, etc.).

---

## ⚙️ Configuración e Instalación

Sigue estos pasos para ejecutar el proyecto en tu entorno local.

### 1. Requisitos Previos
* [.NET SDK 8.0](https://dotnet.microsoft.com/download) instalado.
* SQL Server (LocalDB o instancia completa).
* Visual Studio 2022 o VS Code.

### 2. Configurar Base de Datos y API
Abre el archivo `appsettings.json` y asegúrate de configurar tu cadena de conexión y la API Key de Renaper:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=VeterinariaDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "RenaperApi": {
    "BaseUrl": "[https://renaper-simulador.onrender.com/api](https://renaper-simulador.onrender.com/api)",
    "ApiKey": "TU_API_KEY_AQUI"
  }
}

```
3. Aplicar Migraciones
Abre la consola del administrador de paquetes (o terminal) en la carpeta del proyecto y ejecuta:

Bash

dotnet ef database update
Esto creará la base de datos VeterinariaDB y las tablas necesarias automáticamente.

4. Ejecutar la Aplicación
Bash

dotnet watch run
La aplicación estará disponible en https://localhost:5001 (o el puerto configurado).

💾 Carga de Datos de Prueba (Seeding)
Si deseas poblar la base de datos con información ficticia (20 clientes, mascotas y atenciones) para probar el sistema:

Abre SQL Server Management Studio (SSMS).

Conéctate a tu base de datos VeterinariaDB.

Ejecuta el script SQL QueryParaLlenarTablas.sql incluido en el repositorio.

📂 Estructura del Proyecto
Data: Modelos de dominio (Entidades EF Core).

DB: Contexto de la base de datos (VeterinariaDBContext).

DTO: Objetos de transferencia de datos (para la API externa).

Pages: Componentes Razor (Vistas de la aplicación).

Service: Lógica de negocio e interfaces.

Shared: Componentes compartidos (Layout, Menú).

📸 Capturas de Pantalla
<img width="1504" height="882" alt="image" src="https://github.com/user-attachments/assets/5cc1ed95-b2f9-44d9-9cfc-f8eeb04a4d17" />
<img width="1508" height="1030" alt="image" src="https://github.com/user-attachments/assets/ef5f5c99-9637-4490-9b8a-2dc61ada45ce" />

<img width="1515" height="1029" alt="image" src="https://github.com/user-attachments/assets/82a41b32-47f1-4363-8225-7daded9b7e7e" />
<img width="1521" height="1028" alt="image" src="https://github.com/user-attachments/assets/294eff67-2a6c-488b-9c97-bb520308fc0a" />
<img width="1531" height="1031" alt="image" src="https://github.com/user-attachments/assets/70848cb1-92f4-4a57-924e-df677c374764" />



Desarrollado con ❤️ en .NET 8.
