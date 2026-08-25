# Posture

An interactive sagittal-plane posture and center-of-mass model that runs entirely in the browser — a single [index.html](index.html), no dependencies, no build step.

![Posture model](https://img.shields.io/badge/stack-vanilla%20HTML%2FJS%2FCanvas-blue)

## What it does

A 2D side-view figure with three modes: **Pose**, **Walk**, and **Run**. In Pose mode you position joints directly; in the gait modes the figure walks or runs on a treadmill driven by biomechanical joint-angle curves, and your posture adjustments layer on top.

Pose mode:

- **Joint angle sliders** (forward +, in degrees) with per-joint zero buttons and draggable on-canvas handles
- **Live COM readout** — balanced/unbalanced pill, COM position vs. the support base, standing + seated twin figures
- **Auto-balance mode** — iteratively adjusts posture to bring the COM over the base (ankle/hip strategy)
- **Fascial continuity mode** — yellow fixed-length front/back fascial lines; move one joint and the others counter-rotate to conserve line length (Gauss-Newton solver)
- **Presets** — Neutral, Forward head, Slouched, Swayback, Over-erect
- **Save/load slots** — snapshot two custom poses (Save 1/2, Pos 1/2)
- **Cosmetics** — model (Guy/Girl), hat, eyes, shirt and skin colors, height slider

Walk / Run modes:

- **Animated gait cycle** on a treadmill — two legs and swinging arms from keyframed hip/knee/foot curves; running has true flight phases
- **Live biomechanics lab** — stance/swing phase bars, hip/knee/foot-pitch strip charts with cycle cursor, ground-reaction-force arrows and curve (~1.15×BW walking, ~2.5×BW running)
- **COM trail** — the center of mass traces its loop; the plumb goes red in flight or when walking's "controlled falling" leaves the stance base
- **Cadence slider, pause (Space), and cycle scrubber**; speed/stride/COM-bounce readouts
- **Posture overlays** — hip-and-up sliders and presets bend the gait (slouched running, forward-head walking); fascia lines animate along the moving body

## Running it

Any of these opens the model in your browser:

| Method | How |
| --- | --- |
| Double-click | [Posture.bat](Posture.bat) |
| VS Code | `Ctrl+Shift+B` (runs the "Open Posture Model in Browser" task — opens Edge as an app window) |
| Directly | Open [index.html](index.html) in any modern browser |

## Files

| File | Purpose |
| --- | --- |
| [index.html](index.html) | The entire app — markup, styles, and canvas rendering/physics in one file |
| [Posture.bat](Posture.bat) | One-click launcher (opens index.html in the default browser) |
| [launcher.cs](launcher.cs) | Optional C# launcher; compiles to an exe that opens index.html next to it |

### Building the C# launcher (optional)

```powershell
csc /target:winexe /out:Posture.exe launcher.cs
```

Place `Posture.exe` in the same folder as `index.html` and run it.
