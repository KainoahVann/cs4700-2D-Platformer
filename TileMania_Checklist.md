# ✅ TileMania — Student Progress Checklist
## CS 4700: Game Design Studio | Unity 6 + C#

**Name:** Kainoah Vann  
**Date Started:** 03/01/2026  
**Date Submitted:** 03/20/2026

---

## 📁 Section 1 — Project Setup

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Created Unity 6 project with **2D URP** template |
| ☑ | ☐ | Installed **Cinemachine** package |
| ☑ | ☐ | Installed **2D Tilemap Extras** (for Rule Tiles) |
| ☑ | ☐ | Created folder structure: Art/, Scripts/, Prefabs/, Audio/, Scenes/ |
| ☑ | ☐ | Imported or created placeholder sprites |
| ☑ | ☐ | Configured sprites: Filter Mode = Point, PPU = 16 |

**Section Notes:** Easy to setup

---

## 🗺️ Section 2 — Tilemap World Building

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Created `Grid` with at least 3 Tilemap children (Ground, Hazards, Background) |
| ☑ | ☐ | Created a **Rule Tile** for the ground |
| ☑ | ☐ | Added at least 5 rules to the Rule Tile (edges, corners, center) |
| ☑ | ☐ | Painted a level with platforms, gaps, and elevation changes |
| ☑ | ☐ | Added **Tilemap Collider 2D** to Ground |
| ☑ | ☐ | Added **Composite Collider 2D** and enabled "Used By Composite" |
| ☑ | ☐ | Hazard Tilemap has collider with **Is Trigger: true** |
| ☑ | ☐ | Background Tilemap has Order in Layer = -1 |

**Section Notes:** Getting the rule tiles and tilemaps was complicated at first, but once they were done it made level design very easy

---

## 🏃 Section 3 — Player Movement & Physics

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Player has: SpriteRenderer, Rigidbody2D, CapsuleCollider2D, Animator |
| ☑ | ☐ | Rigidbody2D: Collision Detection = Continuous, Freeze Rotation Z = true |
| ☑ | ☐ | `PlayerMovement.cs` attached and compiles without errors |
| ☑ | ☐ | `GroundCheck` child object created at bottom of player |
| ☑ | ☐ | Player moves left/right with A/D or arrow keys |
| ☑ | ☐ | Player jumps with Space and only when grounded |
| ☑ | ☐ | Sprite flips direction when moving |
| ☑ | ☐ | Better jump physics applied (fall feels snappy, tap = short jump) |

**Section Notes:** Attached player movement needed a couple of tweaks to work

---

## 🎬 Section 4 — Player Animation

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | `Player_Idle` animation clip created |
| ☑ | ☐ | `Player_Run` animation clip created |
| ☑ | ☐ | `Player_Jump` animation clip created |
| ☑ | ☐ | `Player_Fall` animation clip created |
| ☑ | ☐ | `Player_Death` animation clip created |
| ☑ | ☐ | Animator parameters set: `isRunning`, `isGrounded`, `yVelocity`, `die` |
| ☑ | ☐ | All transitions wired correctly (no floating states) |
| ☑ | ☐ | "Has Exit Time" unchecked on all movement transitions |
| ☑ | ☐ | Animations play correctly in Play Mode |

**Section Notes:** Had some trouble making animations look how I wanted, but eventually figured it out

---

## 📷 Section 5 — Camera

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Cinemachine Virtual Camera added to scene |
| ☑ | ☐ | Camera follows player smoothly |
| ☑ | ☐ | Camera confined to level bounds (CinemachineConfiner2D) |
| ☑ | ☐ | Camera shake implemented in `CameraShake.cs` |
| ☑ | ☐ | Camera shakes when player takes damage |

**Section Notes:** My camera kept falling through the ground because I had forgotten to check a box nad took a while 

---

## 🔲 Section 6 — Layers & Collision Matrix

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Created layers: Ground, Player, Enemy, Hazard, PlayerProjectile, EnemyProjectile |
| ☑ | ☐ | Ground Tilemap assigned to Ground layer |
| ☑ | ☐ | Player assigned to Player layer |
| ☑ | ☐ | Layer Collision Matrix configured (PlayerProjectile ✗ Player, Enemy ✗ Enemy) |
| ☑ | ☐ | PlayerMovement Ground Check uses correct layer mask |

**Section Notes:** Ground check gave me the most issues and player was not ever touching the ground, but it was a hitbox issue

---

## 👾 Section 7 — Enemy AI

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Enemy prefab created with Rigidbody2D, CapsuleCollider2D, Animator |
| ☑ | ☐ | Enemy assigned to Enemy layer |
| ☑ | ☐ | `EnemyPatrol.cs` attached, enemy moves left and right |
| ☑ | ☐ | Enemy turns at waypoint boundaries |
| ☑ | ☐ | Enemy turns at ledges (no ground detected) |
| ☑ | ☐ | Enemy sprite flips direction correctly |
| ☑ | ☐ | `EnemyHurt.cs` — touching enemy damages player |
| ☑ | ☐ | Enemy `Die()` plays animation and removes GameObject |
| ☑ | ☐ | At least **2 enemies** placed in the level |

**Section Notes:** My enemy patrol doesn't completely work and sometimes the enemies do not walk, im not sure how to fix it but it works most of the time.

---

## 🏹 Section 8 — Shooting System

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Arrow prefab created with Rigidbody2D (gravity 0), BoxCollider2D (trigger) |
| ☑ | ☐ | Arrow assigned to PlayerProjectile layer |
| ☑ | ☐ | `Arrow.cs` moves in correct direction |
| ☑ | ☐ | Arrow destroys on hitting an enemy |
| ☑ | ☐ | Arrow destroys on hitting ground |
| ☑ | ☐ | Arrow has max lifetime (auto-destroys after 3s) |
| ☑ | ☐ | `PlayerShooter.cs` fires on left-click (Fire1) |
| ☑ | ☐ | Fire rate limit prevents spam |
| ☑ | ☐ | Arrows fire in the direction the player faces |
| ☑ | ☐ | `FirePoint` child object positioned correctly |

**Section Notes:** No issues with the arrow and shooting system

---

## ❤️ Section 9 — Health & Damage

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | `PlayerHealth.cs` tracks current / max health |
| ☑ | ☐ | UI hearts update when player takes damage |
| ☑ | ☐ | Invincibility frames work after taking damage (flashing effect) |
| ☑ | ☐ | Player death triggers game over flow |
| ☑ | ☐ | `GameSession.cs` singleton persists across scenes |
| ☑ | ☐ | Lives system: death decrements lives, reloads scene |
| ☑ | ☐ | Out of lives → loads Game Over scene |
| ☑ | ☐ | Hazard tiles damage/kill player on touch |

**Section Notes:** No issues with this section

---

## 🎬 Section 10 — Scenes & Game States

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Build Settings has all scenes in correct order |
| ☑ | ☐ | Main Menu scene with Start button works |
| ☑ | ☐ | Game Over scene exists and loads correctly |
| ☑ | ☐ | Level Exit triggers next level load |
| ☑ | ☐ | Win scene or win condition implemented |

**Section Notes:** No issues

---

## 🎵 Section 11 — Audio & Polish

| ✅ Done | ⚠️ Stuck | Task |
|:---:|:---:|---|
| ☑ | ☐ | Background music loops on AudioSource |
| ☑ | ☐ | Jump SFX plays when player jumps |
| ☑ | ☐ | Shoot SFX plays when player fires |
| ☑ | ☐ | Damage SFX plays when player is hit |
| ☑ | ☐ | At least 1 particle effect (death, hit, collect, etc.) |

**Section Notes:** No issues, but audio adds a lot to how the game feels 

---

## 🎨 Quality Standards

### Technical Quality
| ✅ | Standard |
|:---:|---|
| ☑ | No null reference errors in Console during normal play |
| ☑ | All scripts organized in correct subfolders |
| ☑ | All tweakable values use `[SerializeField]` — no magic numbers |
| ☑ | Enemies are **prefabs** (not unique scene objects) |
| ☑ | Arrow is a **prefab** |
| ☑ | GameObjects are named clearly in Hierarchy |
| ☑ | Unused GameObjects/scripts removed |

### Design Quality
| ✅ | Standard |
|:---:|---|
| ☑ | Level has a clear start and end |
| ☑ | Level has varied terrain (high platforms, low areas, gaps) |
| ☑ | Difficulty ramps up through the level |
| ☑ | Player can distinguish hazards from safe ground visually |
| ☑ | Game is playable start to finish without bugs |

---

## 🚀 Extension Features (Optional — Choose 1+)

| ✅ | Difficulty | Feature |
|:---:|:---:|---|
| ☐ | 🟢 | Double jump |
| ☐ | 🟢 | Animated collectible coins/gems |
| ☐ | 🟢 | Multiple enemy types (reskins with different speeds) |
| ☐ | 🟡 | Checkpoint system |
| ☐ | 🟡 | Moving platform |
| ☐ | 🟡 | Enemy with ranged attack |
| ☑ | 🟡 | Score system with on-screen display |
| ☐ | 🔴 | Boss enemy with health bar |
| ☑ | 🔴 | Multiple levels (3+) with scene transitions |
| ☐ | 🔴 | Save system (high score persists between sessions) |

**Extension chosen:** Point system for collecting coins and multiple levels  
**Brief description of what you added:** My game has 3 levels total, and coins throughout the levels that will add to your point counter 

---

## 📤 Submission Checklist

| ✅ | Task |
|:---:|---|
| ☑ | Project builds without errors (File → Build Settings → Build And Run) |
| ☑ | Game is playable from Main Menu to Game Over/Win |
| ☑ | Submitted GitHub repository link on Canvas |
| ☑ | Repository is **public** or instructor has been given access |
| ☑ | All 3 tutorial documents included in repo (`Tutorial.md`, `Checklist.md`, `QuickReference.md`) |
| ☑ | Completed **Reflection Questions** (below) |

---

## 🪞 Reflection Questions

Answer these in **2–4 sentences each**. These are the same questions you'll revisit across all four projects — track how your thinking evolves!

**1. What was your rapid prototype goal for this project?**

For this project I wanted to quickly set up the tools I needed, such as tilemaps, rule tiles, and prefabs, so then I could quickly assemble levels without needing to add any more work besides designing and placing prefabs on drawn tiles.

**2. How closely did your final game match your original prototype vision? What changed and why?**

My original vision was about the same, except I wanted to change the theme. I was not able to find any free tilesets that worked well for my vision, so I changed the theme to something that had a better spritesheet online.

**3. What is the most technically challenging thing you implemented? How did you solve it?**

The rule tiles were very confusing to me at first, and I needed to research videos online to really get the hang of it.

**4. If you had one more week, what would you add or change?**

If I was to have more time, I think I would add different enemy types an maybe a boss at the end that has a different script than normal enemies.

**5. How does your approach to game development now compare to when you started the course?**

I realize planning everything out and laying the groundwork (tilemaps, layers, folder organization, etc.) makes the actual development process much easier than trying to do these things as I need them.
---

*TileMania Checklist | CS 4700: Game Design Studio | Unity 6 + C#*
