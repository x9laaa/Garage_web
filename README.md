# Garage - Administrador de Eventos ASP.NET

¿Qué es Garage?

Garage es una productora ficticia dedicada a la organización de conciertos y exposiciones. Como parte de su evaluación de tecnologías, la empresa solicita el desarrollo de un sistema web que les permita:

- Registrar eventos con detalles específicos según su tipo (concierto o exposición).
- Visualizar y listar los eventos ingresados.
- Consultar los detalles de un evento en particular.
- Validar que los datos ingresados sean correctos.
- Acceder al sistema desde un navegador web interno gracias al despliegue en IIS.

Funcionalidades principales

- Registro de eventos con validaciones específicas.
- Listado dinámico de todos los eventos ingresados.
- Visualización detallada de eventos según su tipo.
- Sistema modular con clases reutilizables y arquitectura clara.
- Sitio desplegado en un servidor web IIS.

Tecnologías utilizadas

- ASP.NET Web Forms (.NET Framework 4.8.1)
- C# con programación orientada a objetos
- Visual Studio para desarrollo
- IIS (Internet Information Services)** para despliegue local
- HTML / CSS para diseño básico de la interfaz

 Arquitectura del Proyecto

El proyecto se divide en tres capas:

1. Garage_UI: Interfaz gráfica y formularios Web Forms.
2. Garage_Business: Lógica de negocio y controladores.
3. Garage_Data: Modelos y clases de almacenamiento en memoria.

Despliegue

El sitio fue publicado y probado en un entorno de servidor con Windows Server 2022, utilizando IIS. El proceso incluyó la creación de una máquina virtual, configuración de IIS y pruebas con múltiples eventos.

Desarrollado por: Alex Carreño
