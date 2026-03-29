# Flappy Bird Clone (Unity Study) 🐦

A faithful recreation of the classic Flappy Bird game, developed in **Unity** to practice game engine fundamentals, 2D physics, and C# scripting.

## 📌 Project Purpose

This project was built to transition from general programming to **Component-Based Development**. It serves as a demonstration of my ability to handle real-time physics, object spawning, and user interface management within a professional game engine.

## 🛠️ Unity Features & Concepts Explored

* **2D Physics (Rigidbody2D & Colliders):** Implementing gravity, upward force (flapping), and collision detection with pipes and the ground.
* **Prefabs & Spawning:** Using a "Spawner" script to instantiate pipe obstacles at random heights and regular intervals.
* **Game State Management:** Handling "Start," "Playing," and "Game Over" states through a centralized Game Manager.
* **UI Canvas:** Displaying real-time scoring and high scores using the Unity UI system.
* **C# Scripting:** Writing clean, modular scripts for player movement, scrolling backgrounds, and trigger-based scoring.

## 🏗️ Technical Highlights

* **Infinite Scrolling:** Implementing a logic to wrap or loop background/ground sprites to create the illusion of endless flight.
* **Trigger Events:** Using `OnTriggerEnter2D` to detect when the bird passes through the gap between pipes to increment the score.

## 🚀 How to Play

You can download the installer from the following file: [FlappyBird](https://github.com/M-Gimenes/FlappyBird/blob/main/FlappyBird.apk) (android only)

---
*Developed as an academic exercise to master the Unity 2D workflow and C# game logic.*
