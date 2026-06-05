<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0%3A7afffd%2C50%3Aa97aff%2C100%3AF3E9DC&height=200&section=header&text=Milti-Move&fontSize=60&fontColor=fff&fontAlignY=38&desc=Sandbox+de+plataformas+2D+con+6+modos+de+movimiento+intercambiables&descAlignY=62&descSize=18" width="100%"/>
</div>

<div align="center">
  <a href="https://github.com/evagr11/Multi-Move"><img alt="Ver Código" src="https://img.shields.io/badge/Ver_Código-181717?style=for-the-badge&logo=github&logoColor=white"></a>
  <a href="https://evagr11.github.io/Curriculum/proyectos/multi-move.html"><img alt="Ver Web" src="https://img.shields.io/badge/Ver_Web-4A90E2?style=for-the-badge&logo=google-chrome&logoColor=white"></a>
  <a href="https://evagr.itch.io/multi-move"><img alt="Ver en itch.io" src="https://img.shields.io/badge/Ver_en_itch.io-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white"></a>
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

*   🤸 **Sistema de Movimiento Avanzado:** Controla un personaje que puede alternar entre **6 modos de movimiento** (Básico, Cohete, Planeador, etc.) al instante pulsando la tecla `M`.
*   🧩 **Arquitectura Modular con `ScriptableObjects`:** Cada modo de movimiento es un `ScriptableObject` independiente, lo que permite configurar y añadir nuevas físicas (gravedad, aceleración, saltos) de forma sencilla y desacoplada.
*   🎨 **Feedback Visual Dinámico:** El color del personaje cambia según su estado vertical (subida, pico, caída, en suelo). Además, se activan partículas para saltos, colisiones y movimiento.
*   🎥 **Cámara Suave:** Un script de seguimiento de cámara (`CameraFollow`) proporciona un movimiento fluido y profesional que acompaña al jugador.

### 🖼️ Capturas del Juego

| Captura 1                                        | Captura 2                                      |
| :----------------------------------------------------------: | :------------------------------------------------------: |
| <img src="https://github.com/user-attachments/assets/12c74a69-3316-4394-a5ac-d417081f0c8f" alt="Imagen de una partida" width="100%"/> | <img src="https://github.com/user-attachments/assets/3dad326d-67dc-43f5-9a8b-90b7a1e5b1ae" alt="Jugador se cura" width="100%"/> |
| *Captura movimiento*                              | *Captura cambio de movimiento*         |

# 🧠 Contexto del Proyecto

Este proyecto fue desarrollado como parte de la asignatura de **Programación** durante el primer año del ciclo formativo de **Desarrollo de Aplicaciones Multiplataforma (DAM)**. Sirvió como una introducción práctica a la programación orientada a objetos en C# dentro del motor de videojuegos Unity, centrándose en la creación de sistemas modulares y la gestión de físicas personalizadas.

# 🛠️ Stack Tecnológico

<div align="center">
  <img alt="Unity" src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white">
  <img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">
  <img alt="Status" src="https://img.shields.io/badge/Status-MVP-brightgreen?style=for-the-badge">
</div>

| Tecnología | Descripción                                          |
| :--------- | :--------------------------------------------------- |
| **Engine** | `Unity 2D` - Motor de juego para el desarrollo 2D/3D. |
| **Lenguaje** | `C#` - Lenguaje principal para la lógica del juego. |
| **Entorno**  | `Visual Studio` - IDE para la escritura de scripts.  |

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
│   ├── CameraFollow.cs
│   ├── Movement.cs
│   ├── MovementStats.cs
│   ├── MovementTypes.cs
│   └── ... (otros assets)
├── Packages/
│   └── manifest.json
└── ProjectSettings/
    └── ... (configuración del proyecto)
```

# 🚀 Cómo Utilizar el Proyecto

Para ejecutar este proyecto localmente, necesitarás tener instalado Unity Hub y una versión compatible de Unity.

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

</br>

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
