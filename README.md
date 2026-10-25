<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0%3A7afffd%2C50%3Aa97aff%2C100%3AF3E9DC&height=200&section=header&text=Multi-Move&fontSize=60&fontColor=fff&fontAlignY=38&desc=Sandbox+de+plataformas+2D+con+6+modos+de+movimiento+intercambiables&descAlignY=62&descSize=18" width="100%"/>
</div>

<div align="center">
  <a href="https://github.com/evagr11/Multi-Move" target="_blank"><img alt="Ver Código" src="https://img.shields.io/badge/Ver_Código-181717?style=for-the-badge&logo=github&logoColor=white"></a>
  <a href="https://evagr11.github.io/Curriculum/proyectos/multi-move.html" target="_blank"><img alt="Ver Web" src="https://img.shields.io/badge/Ver_Web-4A90E2?style=for-the-badge&logo=google-chrome&logoColor=white"></a>
  <a href="https://evagr.itch.io/multi-move" target="_blank"><img alt="Ver en itch.io" src="https://img.shields.io/badge/Ver_en_itch.io-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white"></a>
</div>

<br>

<div align="center">
  <a href="https://git.io/typing-svg"><img src="https://readme-typing-svg.demolab.com/?font=JetBrains+Mono&size=18&duration=3500&pause=800&color=7afffd&center=true&vCenter=true&width=600&lines=Desarrollado+en+Unity+con+C%23%3BSistema+de+movimiento+modular%3B6+modos+de+f%C3%ADsicas+intercambiables%3BUso+de+ScriptableObjects%3BPart%C3%ADculas+y+feedback+visual" alt="Typing SVG" /></a>
</div>

# 🚀 Sobre el Proyecto

**Multi-Move** es un **sandbox de plataformas 2D** que explora un sistema de movimiento avanzado con **múltiples configuraciones intercambiables** en tiempo real. El jugador controla un cubo que puede moverse, saltar y cambiar entre 6 modos de movimiento únicos, cada uno implementado como un `ScriptableObject` para una arquitectura modular y fácilmente extensible. El proyecto incluye un sistema de partículas visuales, cambios de color dinámicos según el estado del jugador y una cámara con seguimiento suave.

<br>

<div align="center">
  <img src="https://github.com/user-attachments/assets/cfb639df-b6b4-4454-8864-0eb05dad0c71" alt="Mockup Multi-Move" width="70%"/>
  <p><em>Mockup Multi-Move</em></p>
</div>

### ✨ Características principales:

*   🤸 **Sistema de Movimiento Avanzado:** Controla un personaje que puede alternar entre **6 modos de movimiento** (Basic, Glider, Hectic, Rocket, Slippy Flappy y Underwater) al instante pulsando la tecla `M`. Un aviso en pantalla muestra durante 2 segundos el modo activo.
*   🧩 **Arquitectura Modular con `ScriptableObjects`:** Cada modo de movimiento es un `ScriptableObject` independiente con 14 parámetros, lo que permite crear nuevas físicas desde el editor sin tocar código (*Create → Movement Stats*).
*   🦘 **Salto con sensación de juego:** La altura depende de cuánto tiempo mantienes `W` (`maxJumpTime`), se puede saltar en el aire tantas veces como permita el modo (`onAirJumps`) y la **gravedad cambia en cada fase del salto**: subida, pico y caída. Así el salto se siente controlable en lugar de una parábola rígida.
*   🎨 **Feedback Visual Dinámico:** El color del personaje cambia con cada salto en el aire siguiendo un degradado, y las partículas cambian de color según la fase (subida, pico, caída o en suelo). Hay partículas para saltar, para intentar saltar sin saltos disponibles, al aterrizar y al moverse.
*   🎥 **Cámara Suave:** Un script de seguimiento (`CameraFollow`) acompaña al jugador con `Vector3.SmoothDamp`.

### 🎮 Controles

<div align="center">

| Tecla | Acción |
| :---: | :----- |
| `A` / `←` | Moverse a la izquierda |
| `D` / `→` | Moverse a la derecha |
| `W` | Saltar (mantener para saltar más alto) |
| `M` | Cambiar de modo de movimiento |

</div>

### ⚙️ Los 6 modos de movimiento

<div align="center">

| Modo | Saltos en el aire | Fuerza de salto | Gravedad (subida / pico / caída) | Cómo se siente |
| :--- | :---------------: | :-------------: | :------------------------------: | :------------- |
| **Basic** | 1 | 10 | 2 / 3 / 4 | Plataformas clásico y equilibrado |
| **Glider** | 2 | 8 | 1 / 1.5 / 2 | Cae despacio (caída máx. 5): planea |
| **Hectic** | 3 | 12 | 5 / 6 / 8 | Muy rápido y nervioso |
| **Rocket** | 1 | 15 | 3 / 6 / 10 | Sube como un cohete y cae en picado |
| **Slippy Flappy** | 5 | 7 | 0.5 / 0.8 / 2 | Resbala en el suelo y aletea en el aire |
| **Underwater** | 99 | 7 | 0.5 / 0.3 / 0.5 | Como nadar: saltos infinitos y lentos |

</div>

### 🖼️ Capturas del Juego

| Movimiento | Cambio de modo |
| :----------------------------------------------------------: | :------------------------------------------------------: |
| <img src="https://github.com/user-attachments/assets/12c74a69-3316-4394-a5ac-d417081f0c8f" alt="Imagen de una partida" width="100%"/> | <img src="https://github.com/user-attachments/assets/3dad326d-67dc-43f5-9a8b-90b7a1e5b1ae" alt="Aviso en pantalla al cambiar de modo de movimiento" width="100%"/> |
| *El cubo en movimiento con sus partículas.* | *Aviso del modo activo al pulsar `M`.* |

# 🧠 Contexto del Proyecto

Este proyecto fue desarrollado como parte de la asignatura de **Programación** durante el primer año del ciclo formativo de **Desarrollo de Aplicaciones Multiplataforma (DAM)**. Sirvió como una introducción práctica a la programación orientada a objetos en C# dentro del motor de videojuegos Unity, centrándose en la creación de sistemas modulares y la gestión de físicas personalizadas.

# 🛠️ Stack Tecnológico

<div align="center">
  <img alt="Unity" src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white">
  <img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">
  <img alt="Status" src="https://img.shields.io/badge/Status-MVP-brightgreen?style=for-the-badge">
</div>

<br>

<div align="center">

| Tecnología | Descripción |
| :--------- | :---------- |
| **Motor** | `Unity 2022.3 LTS` (2D) |
| **Lenguaje** | `C#` |
| **Físicas** | `Rigidbody2D`, `Physics2D.Raycast` para detectar el suelo, material sin fricción |
| **Datos** | `ScriptableObject` para cada modo de movimiento |
| **Interfaz** | `TextMesh Pro` para el aviso de modo |
| **Entorno** | `Visual Studio` |

</div>

# 📂 Estructura del Proyecto

La estructura de archivos se organiza principalmente dentro de la carpeta `Assets`, separando los scripts principales, los `ScriptableObjects` que definen los modos de movimiento y la escena principal.

```bash
Multi-Move/
├── Assets/
│   ├── MovimientoS/
│   │   ├── Basic.asset
│   │   ├── Glider.asset
│   │   ├── Hectic.asset
│   │   ├── Rocket.asset
│   │   ├── Slippy Flappy.asset
│   │   └── Underwater.asset
│   ├── Scenes/
│   │   └── SampleScene.unity
│   ├── CameraFollow.cs           # Cámara que sigue al jugador
│   ├── ContantRotationReset.cs   # Impide que el objeto gire (rotación fija)
│   ├── Movement.cs               # Movimiento, saltos, gravedad por fase, colores y partículas
│   ├── MovementStats.cs          # ScriptableObject con los parámetros de cada modo
│   ├── MovementTypes.cs          # Cambio de modo con la tecla M y aviso en pantalla
│   ├── SinFriccion.physicsMaterial2D
│   └── TextMesh Pro/             # Paquete de texto de Unity
├── Packages/
│   └── manifest.json
└── ProjectSettings/
    └── ... (configuración del proyecto)
```

# 🚀 Cómo Utilizar el Proyecto

Para ejecutar este proyecto localmente necesitas **Unity Hub** y **Unity 2022.3 LTS** (el proyecto se creó con la 2022.3.50f1). Si solo quieres jugar, está [en itch.io](https://evagr.itch.io/multi-move).

1.  **Clona el repositorio:**
    ```bash
    git clone https://github.com/evagr11/Multi-Move.git
    ```

2.  **Abre el proyecto en Unity Hub:**
    *   Abre Unity Hub.
    *   Haz clic en "Add" o "Abrir".
    *   Navega hasta la carpeta `Multi-Move` que acabas de clonar y selecciónala.

3.  **Abre la escena principal:**
    *   Dentro del editor de Unity, ve al panel `Project`.
    *   Navega a la carpeta `Assets/Scenes/`.
    *   Haz doble clic en el archivo `SampleScene.unity` para abrirla.

4.  **Ejecuta el juego:**
    *   Presiona el botón de **Play** en la parte superior central del editor de Unity para iniciar el juego.
    *   Usa `A/D` o las flechas para moverte, `W` para saltar y `M` para cambiar el modo de movimiento.

<br>

<div align="center">
  <p>Creado por <strong>Eva Gallardo</strong></p>
  <a href="https://github.com/evagr11" target="_blank">
    <img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub">
  </a>
  <a href="https://www.linkedin.com/in/eva-gallardo-romero-830362349/" target="_blank">
    <img src="https://img.shields.io/badge/LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn">
  </a>
</div>


<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0%3A7afffd%2C50%3Aa97aff%2C100%3AF3E9DC&height=120&section=footer" width="100%"/>
</div>
