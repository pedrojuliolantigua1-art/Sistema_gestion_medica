# Actividad: Diseno de Sistema de Gestion de Citas Medicas

## 1. Analisis del problema 

### Problema de la clinica

La clinica actualmente gestiona las citas de forma manual. Los pacientes llaman por telefono, se revisa la disponibilidad del medico y luego registra la cita
en una hoja de calculo. Hacerlo de esta manera tenia los siguientes problemas:

- Citas duplicadas.
- Dificultad para consultar la disponibilidad de los medicos.
- Cancelaciones mal registradas.
- Informacion repetida de pacientes y medicos.
- Falta de organizacion por especialidad.
- Dificultad para enviar recordatorios.
- Codigo dificil de mantener cuando se agregan nuevas funcionalidades.

Por esta razon se propone un sistemaque permita administrar pacientes, medicos, especialidades, citas y recordatorios de una forma mas organizada.

### Modulos identificados

Para evitar que todo el sistema este concentrado en una sola clase, tengo los siguientes modulos

- **Pacientes:** permite registrar y consultar los datos de los pacientes.
- **Medicos:** permite registrar medicos y asignarle a una especialidad.
- **Especialidades:** Con esta organizamos los medicos segun su area.
- **Citas:** permite agendar, cancelar, reprogramar y consultar citas medicas.
- **Recordatorios:** permite enviar recordatorios de citas.
- **Base de datos:** Para almacenar los datos de manera persistente utilice Entity Framework Core y SQL Server.
- **Interfaz grafica:** permite que el usuario interactue con el sistema mediante formularios Windows Forms.

### Funcionalidades de la primera version

La primera version del sistema incluye las funcionalidades principales solicitadas por la clinica:

- Registrar pacientes.
- Registrar medicos.
- Registrar especialidades medicas.
- Asignar medicos a una especialidad.
- Agendar citas medicas.
- Consultar citas.
- Cancelar citas.
- Reprogramar citas.
- Enviar recordatorio de cita por correo electronico.

### Funcionalidades para versiones futuras

Las siguientes funcionalidades se dejan para futuras versiones:

- Facturacion.
- Recetas medicas.
- Historial clinico.
- Seguros medicos.
- Reportes administrativos.
- Usuarios y roles.
- Recordatorios por SMS o WhatsApp.

Estas funcionalidades no se implementan en esta primera version porque no fueron solicitadas en el alcance inicial. Agregarlas desde el principio aumentaria la complejidad del sistema, el tiempo de desarrollo y el riesgo de errores.

## 2. Diseño orientado a objetos

### Clases principales

| Clase | Atributos principales | Metodos principales | Responsabilidad |
|---|---|---|---|
| `People` | `Id`, `Cedula`, `Nombre`, `Apellido`, `Telefono`, `Email` | `ValidarDatosBasicos()` | Contiene datos comunes de pacientes y medicos. |
| `Paciente` | `FechaNacimiento` | Hereda validacion de `People` | Representa a un paciente de la clinica. |
| `Medico` | `EspecialidadId`, `Especialidad` | Hereda validacion de `People` | Representa a un medico y su especialidad. |
| `Especialidad` | `Id`, `Nombre`, `Descripcion` | No tiene metodos de negocio propios | Representa una especialidad medica. |
| `Cita` | `PacienteId`, `MedicoId`, `FechaHora`, `Estado`, `Motivo` | No tiene metodos de negocio propios | Representa una cita medica. |
| `Recordatorio` | `CitaId`, `Tipo`, `Estado`, `EnviadoEn` | No tiene metodos de negocio propios | Representa un recordatorio de cita. |
| `PacienteService` | Repositorio de pacientes | `Registrar()`, `Actualizar()`, `Eliminar()`, `ObtenerTodos()` | Maneja reglas de negocio de pacientes. |
| `MedicoService` | Repositorio de medicos | `Registrar()`, `Actualizar()`, `Eliminar()`, `ObtenerTodos()` | Maneja reglas de negocio de medicos. |
| `EspecialidadService` | Repositorio de especialidades | `Registrar()`, `Actualizar()`, `Eliminar()`, `ObtenerTodas()` | Maneja reglas de negocio de especialidades. |
| `CitaService` | Repositorio de citas | `Agendar()`, `Cancelar()`, `Reprogramar()`, `ObtenerPorPaciente()`, `ObtenerPorMedico()` | Maneja reglas de negocio de citas. |
| `RecordatorioService` | Repositorio y enviador de recordatorios | `EnviarRecordatorio()`, `ObtenerPorCita()` | Maneja el proceso de envio de recordatorios. |
| `EnviadorEmail` | Contexto de base de datos | `Enviar()` | Envia los recordatorios por correo electronico. |
| `AppDbContext` | `DbSet` de entidades | `OnConfiguring()`, `OnModelCreating()` | Configura la base de datos y relaciones. |

### Relaciones entre clases

- `Paciente` hereda de `People`.
- `Medico` hereda de `People`.
- `Medico` pertenece a una `Especialidad`.
- `Cita` pertenece a un `Paciente`.
- `Cita` pertenece a un `Medico`.
- `Recordatorio` pertenece a una `Cita`.
- Los formularios usan servicios.
- Los servicios usan repositorios.
- Los repositorios usan `AppDbContext`.
- El envio de recordatorios depende de la interfaz `IEnviadorRecordatorio`.

## 3. Aplicacion de principios

### SoC - Separation of Concerns ¿Cómo separaste las responsabilidades del sistema?

Separe las responsabilidades del sistema en varias capas:
- Los formularios manejan la interfaz grafica.
- Los servicios manejan la logica de negocio.
- Los repositorios manejan el acceso a datos.
- Los modelos representan las entidades del sistema.
- Las interfaces definen contratos.
- La carpeta de notificaciones maneja el envio de recordatorios.

### DRY - Don't Repeat Yourself ¿Qué lógica evitaste repetir?

- La clase `People` para compartir datos comunes entre `Paciente` y `Medico`.
- El metodo `ValidarDatosBasicos()` para validar nombre, apellido y email. De esta forma, si una validacion cambia, no hay que modificarla en muchos lugares.
- La interfaz generica `ICrud<T>` para operaciones comunes como agregar, actualizar, eliminar y consultar.

### KISS - Keep It Simple ¿Cómo mantuviste simple la solución?


La solucion se mantiene simple porque solo incluye lo necesario para resolver el problema inicial de la clinica:
- Pacientes.
- Medicos.
- Especialidades.
- Citas.
- Recordatorios por email.

No agregue ningun modulo complejo innecesario.

### YAGNI - You Aren't Gonna Need It ¿Qué funcionalidades decidiste no implementar todavía?

Se decidio no implementar todavia:

- Facturacion.
- Recetas medicas.
- Historial clinico.
- Seguros medicos.
- Telemedicina.
- Chat medico.
- Inteligencia artificial.

### SRP - Single Responsibility Principle ¿Cada clase tiene una sola responsabilidad?

- `CitaService` maneja reglas de citas.
- `CitaRepository` maneja datos de citas.
- `RecordatorioService` maneja el proceso de recordatorios.
- `EnviadorEmail` se encarga del envio por correo.
- `FormCitas` maneja la interfaz de citas.

### OCP - Open/Closed Principle ¿La solución permite agregar nuevas funcionalidades sin romper lo
existente?

La solucion permite agregar funcionalidades nuevas sin modificar demasiado el codigo existente. 
Por ejemplo, hoy se envia recordatorio por email mediante `EnviadorEmail`, pero en el futuro se puede crear
`EnviadorSms` o `EnviadorWhatsApp` implementando la misma interfaz `IEnviadorRecordatorio`.

### LSP - Liskov Substitution Principle ¿Las clases hijas pueden reemplazar correctamente a sus clases padre?

`Paciente` y `Medico` pueden reemplazar correctamente a su clase base `People`, porque ambos comparten los 
datos basicos de una persona y pueden usar la validacion comun sin romper el comportamiento esperado.

### ISP - Interface Segregation Principle ¿Evitaste interfaces grandes con métodos innecesarios?

Se evitaron interfaces grandes con metodos innecesarios. Por ejemplo:

- `ICrud<T>` contiene solo operaciones generales.
- `ICitaRepository` agrega solo consultas especificas de citas.
- `IMedicoRepository` agrega solo consultas especificas de medicos.
- `IEnviadorRecordatorio` solo define el metodo `Enviar()`.

Tambien se eliminaron interfaces vacias como `IPacienteRepository` e `IEspecialidadRepository`, porque no agregaban
metodos nuevos de momento y bastaba con usar `ICrud<Paciente>` e `ICrud<Especialidad>`.

### DIP - Dependency Inversion Principle ¿Las clases dependen de abstracciones y no de implementaciones
concretas?

Los servicios dependen de abstracciones y no directamente de implementaciones concretas:

- `CitaService` depende de `ICitaRepository`.
- `MedicoService` depende de `IMedicoRepository`.
- `PacienteService` depende de `ICrud<Paciente>`.
- `EspecialidadService` depende de `ICrud<Especialidad>`.
- `RecordatorioService` depende de `IRecordatorio` e `IEnviadorRecordatorio`.

## 4. Justificacion tecnica

### 1. Por que se dividio el sistema en esos modulos

Se dividio el sistema en modulos porque cada parte cumple una funcion diferente.
La gestion de pacientes no debe mezclarse con la gestion de citas, y el envio de correos no debe mezclarse con
el acceso a la base de datos ni con los formularios.Esta division permite que el codigo sea mas claro, 
mantenible y facil de extender.

### 2. Por que esas clases son necesarias

Las clases principales son necesarias porque representan elementos reales del problema:

- `Paciente` representa a las personas que reciben atencion.
- `Medico` representa a los profesionales que atienden las citas.
- `Especialidad` organiza los medicos por area.
- `Cita` representa el evento principal del sistema.
- `Recordatorio` representa el aviso enviado al paciente.
- Los servicios son necesarios para colocar las reglas de negocio.
- Los repositorios son necesarios para separar el acceso a datos.
- Formularios son necesarios para poder interactuar

### 3. Que clases o funcionalidades se decidio no crear y por que

- `Factura`.
- `RecetaMedica`.
- `HistorialClinico`.
- `SeguroMedico`.
- `ConsultaVirtual`.
- `ChatMedico`.
- `Modulos de inteligencia artificial`.

No se crearon porque el requerimiento inicial se enfoca en administrar citas medicas. Agregar esas clases 
ahora violaria el principio YAGNI y haria el proyecto mas dificil de mantener.

### 4. Donde podria aparecer codigo repetido

El codigo repetido podria aparecer en:

- Validacion de campos vacios.
- Validacion de fechas.
- Validacion de disponibilidad del medico.
- Operaciones CRUD.
- Mensajes de error.
- Logica de envio de recordatorios.

### 5. Como se podria extender el sistema en el futuro
Se puede extender este sistema: 
- Nuevos tipos de recordatorio, como SMS o WhatsApp.
- Filtros visuales para consultar citas por paciente o medico.
- Reportes de citas por fecha.
- Facturacion.
- Historial clinico.
- Gestion de usuarios y roles.

Gracias a las interfaces y a la separacion por capas, estas mejoras pueden agregarse sin cambiar toda la estructura actual.

### 6. Que principio fue mas dificil de aplicar y por que

El principio mas dificil de aplicar fue OCP, porque requiere pensar en el crecimiento futuro sin complicar
demasiado la primera version. Por ejemplo, el sistema debe permitir nuevos tipos de recordatorio, pero sin 
construir desde el inicio funciones que todavia no se necesitan.

## 5. Preguntas de reflexion

### 1. Que pasaria si todo el sistema se implementa en una sola clase
Si todo el sistema se implementa en una sola clase, esa clase tendria demasiadas responsabilidades. 
Registraria pacientes, medicos, citas, enviaria correos y manejaria la base de datos. Esto haria que el 
codigo sea dificil de entender, probar, corregir y extender.

### 2. Que riesgos existen si se agregan funcionalidades que el cliente no pidio
El principal riesgo es aumentar la complejidad sin necesidad. Tambien se perderia tiempo desarrollando 
funciones que tal vez el cliente no use. Ademas, mientras mas codigo tenga el sistema, mayor es la 
posibilidad de errores.

### 3. Como afecta la repeticion de codigo al mantenimiento
La repeticion de codigo afecta el mantenimiento porque obliga a modificar varios lugares cuando cambia
una regla. Si una validacion esta repetida y se corrige solo en una parte, el sistema puede quedar 
inconsistente.

### 4. Por que una solucion simple puede ser mejor que una solucion demasiado compleja
Una solucion simple es mas facil de entender, probar y mejorar. Tambien permite entregar una primera version
funcional mas rapido. Una solucion demasiado compleja puede resolver problemas que todavia no existen y
dificultar los cambios futuros que se le vayan a realizar.

### 5. Que ventaja tiene separar la logica de citas, pacientes y medicos
La ventaja es que cada parte se puede modificar de forma independiente. 
Por ejemplo, se puede cambiar la regla para agendar citas sin afectar el registro de pacientes o medicos.

### 6. Como se puede preparar el sistema para crecer sin hacerlo complicado desde el inicio
Se puede preparar usando una estructura clara, servicios separados, repositorios, interfaces pequenas y 
clases con responsabilidades bien definidas. Asi el sistema queda listo para crecer, pero sin agregar 
funcionalidades innecesarias desde el inicio.

## 6. Informacion tecnica del proyecto

### Descripcion general

Este proyecto es una aplicacion de escritorio desarrollada en C# con Windows Forms. 
Utiliza Entity Framework Core para conectarse a una base de datos SQL Server.
El sistema esta organizado en carpetas que separan los modelos, formularios, servicios, repositorios, 
interfaces, notificaciones y configuracion de base de datos.

### Tecnologias utilizadas
- C#
- .NET Windows Forms
- Entity Framework Core
- SQL Server

### Uso y funcionamiento del programa

Primero entro a la pagina principal, donde hay un menu que tiene la distintas areas que gestiona nuestro
programa.

<img width="316" height="214" alt="image" src="https://github.com/user-attachments/assets/c365461c-8f91-40bf-a2f5-8e87663f164a" />

En la seccion de pacientes, hay puedo registrar a los pacientes

<img width="931" height="597" alt="image" src="https://github.com/user-attachments/assets/a23c380b-5ed1-413b-83a6-d95645d4ce09" />

En la seccion de medicos, puedo registrar los medicos y asignarle una especialidad de las que se encuentran disponibles

<img width="939" height="634" alt="image" src="https://github.com/user-attachments/assets/5202f7f1-0ba8-46d0-8837-ad4f133a4213" />

En la seccion de gestion de especialidades agrego las areas posible para asignar a un medico

<img width="1027" height="611" alt="image" src="https://github.com/user-attachments/assets/76584f23-b1f9-44a2-a3cb-707fe0e0645f" />
<img width="1033" height="609" alt="image" src="https://github.com/user-attachments/assets/de1ed6a7-eeea-47b2-9c11-37c8a3e4a615" />

Al igual que en cada pantalla te lanza un comunicado de que se guardaron los datos correctamente y se actualiza
la tabla

<img width="909" height="610" alt="image" src="https://github.com/user-attachments/assets/c1167ff3-4bda-43ed-bfbb-fe70838044bd" />

Aqui se agenda una cita , se cancela, se reprograman y tambien se envian un recordatorio que es por correo en este caso

<img width="862" height="498" alt="image" src="https://github.com/user-attachments/assets/b89d5fbd-15c6-47d2-b12b-94484b6608e8" />
 Aqui la prueba, donde recibo un correo con un recordatorio de mi cita

El sistema propuesto resuelve el problema principal de la clinica: organizar la gestion de citas medicas. La solucion aplica separacion de responsabilidades, evita repeticion de codigo, mantiene una estructura simple y deja espacio para crecer en futuras versiones sin agregar complejidad innecesaria desde el inicio.
