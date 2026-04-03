# Flappy Bird Clone — Unity 2D

A faithful recreation of the classic Flappy Bird built with **Unity** and **C#**, developed as a hands-on study of 2D game mechanics, physics, and mobile deployment.

---

## Overview

This project replicates the core loop of the original game: tap to flap, avoid the pipes, survive as long as possible. The focus was on understanding how Unity's component system handles real-time physics, procedural obstacle generation, and scene state management — all common patterns in 2D game development.

## Technical Highlights

| System | Implementation |
|---|---|
| **Physics** | `Rigidbody2D` for gravity and upward impulse on tap; `CircleCollider2D` / `BoxCollider2D` for collision detection |
| **Obstacle Spawner** | Pipe prefabs instantiated at randomized vertical positions on a fixed time interval |
| **Scoring & UI** | Unity Canvas with real-time score tracking and a Game Over overlay |
| **Scene Management** | State reset and scene reload triggered on collision |
| **Background Scrolling** | Looping texture script that simulates infinite lateral movement |
| **Animations** | Three playable bird variants (Blue, Red, Yellow) with individual animation controllers |
| **Transitions** | Fade in/out controller between Menu and Game scenes |
| **Audio** | Full sound design — wing flap, pipe pass, collision hit, death, and ambient wind |

## Requirements

- **Unity:** 2021.3 LTS or later
- **Language:** C#
- **Platform:** Android

## Play It

Download the Android APK directly from this repository:

**[Download FlappyBird.apk](https://github.com/M-Gimenes/FlappyBird/blob/main/FlappyBird.apk)**

> Enable *Install from unknown sources* on your Android device before installing.

---

*Built to study Unity 2D, C# scripting, and Android build pipeline.*
