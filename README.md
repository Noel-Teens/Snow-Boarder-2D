# Snow Boarder

A simple 2D snowboarding game created in Unity as a learning project.

## About

Snow Boarder is a 2D physics-based snowboarding game where the player controls a snowboarder sliding down slopes. The objective is to reach the finish line while avoiding crashes. This project was developed to learn Unity game development fundamentals.

## Gameplay

- **Movement**: Use arrow keys to control the snowboarder
  - **Left/Right Arrow Keys**: Rotate the snowboarder
  - **Up Arrow Key**: Boost speed
- **Objective**: Navigate down the slope and reach the finish line
- **Challenge**: Avoid crashing into the ground with your head

## Features

- Physics-based snowboard movement with torque rotation
- Speed boost mechanics
- Crash detection system
- Particle effects for crashes and finish line
- Audio feedback for game events
- Automatic scene restart after crash or completion

## Technical Details

- **Engine**: Unity 6000.1.8f1
- **Platform**: 2D
- **Physics**: Unity's 2D Rigidbody and SurfaceEffector2D
- **Input**: Unity's legacy Input system

### Scripts

- `PlayerController.cs` - Handles player movement, rotation, and speed control
- `CrashDetector.cs` - Detects collisions with ground and triggers crash sequence
- `FinishLine.cs` - Handles finish line detection and level completion
- `DustTrail.cs` - Manages visual dust trail effects

## Controls

| Key | Action |
|-----|--------|
| ← → | Rotate snowboarder left/right |
| ↑ | Boost speed |

## Learning Objectives

This project demonstrates understanding of:
- Unity 2D physics system
- Collision detection with triggers
- Particle systems
- Audio integration
- Scene management
- Basic game state management
- Unity component architecture

## Setup

1. Open the project in Unity 6000.1.8f1 or later
2. Load the main scene from the Scenes folder
3. Press Play to start the game

## Assets Structure

```
Assets/
├── Scenes/          # Game scenes
├── Scripts/         # C# game logic scripts
├── Sprites/         # 2D graphics and textures
└── Settings/        # Unity render pipeline settings
```

---

*This project was created as part of learning Unity game development.*
