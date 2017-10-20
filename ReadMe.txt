===============================
Name: shipEffectsContinued SoundMod
Version: 1.0.8.3
Original Author: Ensou - Maintained by Galileo
===============================

This is a sound mod for Kerbal Space Program aimed to add Dynamic sound effects to your ship.
It enhances the IVA experience.

============
INSTALLATION
============

Delete previous installation
Extract and merge the folder "GameData" folder with your existing "GameData" directory

NOTE: This version is for KSP 1.2.x and 1.3.x
If you're running KSP 1.1.x, please use version 1.0.5 of this mod instead.

=========
CHANGELOG
=========
1.0.8-1.0.8.3 | 10-20-17
- Fix typo in code - Thanks Fwiffo
- Updated assembly version

1.0.8-1.0.8.1 | 10-10-17
- recomplile for 1.3.1

1.0.8-1.0.8.1 | 06-22-17
- Make sounds actually audible

1.0.7-1.0.8 | 06-06-17
- Compile against KSP 1.3.0 release.
- All new sound effects.

1.0.6-1.0.7 | 10-17-16
- Compile against KSP 1.2 final release.

1.0.5-1.0.6 | 09-15-16
- Compile against KSP 1.2 pre-release. Due to changes to KSP API DLL's, this version is not backward-compatible with older KSP's.

1.0.4-1.0.5 | 09-15-16
- Minor fix and a recompile to make compatible with KSP 1.1.3.

1.0.3-1.0.4 | 10-12-15
- Updated Source Code

1.0.2-1.0.4 | 08-28-15
- Removed Debug Line that was spamming KSP output log
- Code optimizations

1.0.1-1.0.4 | 08-23-15
- Fixed Compatibility issues with the Real Fuels mod by NathanKell

1.0.0-1.0.4 | 08-23-15
- Maintenance Build, code updated for functionality in KSP 1.0.4

0.2.6-0.90 | 04-18-15
- Improved Thump Sounds response, now it wont play unless the ship experienced a sudden increase in GeeForce fast enough
- Added Heavy Thump sounds for Higher GeeForce Peaks
- Added Stress Sounds response starting from 6G and beyond
- General House Keeping within the code
- Two new Settings, Resistance Multiplier and ReEntry Multiplier

0.2.4-0.90 | 04-16-15
- fixed dynamic response locking at high TWRs causing sounds to not ease
- replaced Thump Sounds to final, replaced code thump code handler
- Docking and Undocking Sounds implement

0.2.3-0.90 | 04-11-15
- Code Re-write, alot more stable, better calculations and ram/cpu friendly
- Better Dynamics response, now takes into account Rotation, Atmosphere Pressure and DeltaV differences (calculated and actual)
- Removed old stress sounds. going to be replaced with a better system
- Engine Response is now more realistic because of better Dynamic response. rattles caused by the engine will ease out when final velocity is reached.
- Audio widen with Unity 3D Audio

0.2.1-0.90 | 04-07-15
-Engine Response is back and better, reworked code
-Fixed Flickering audio at High TWR and super G-forces by redoing the Dynamic Volume control and limiting it
-Converted sounds to wav, easier to the game for a sacrifice of size.
-Redid Re-entry response, code borrowed from KerbQuake

0.2-0.90 | 04-05-2015
-improved and new sounds!
-Thump Sounds (open parachute, land) are powered by Acceleration = Gravity/Mass
-Aerodynamic and Atmospheric features are now in! 
-Now sounds respond to Atmospheric Entries. 
-cleaner code, new calculation method for dynamic responses
-EngineResponse Disabled for now, was working but is throwing nullexceptions when paired with other mods that uses moduleengines

0.1.4-0.90 | 04-04-2015
- added ProbeControlRoom Support, disables sounds when using ProbeControlRoom IVA.
- redid settings to respond a little bit better.

0.1.3-0.90 | 04-04-2015
- fixed null exceptions
- added thirdpersonview sounds
- added velocityEaser to easeGForces when at lower velocity or stationary, getting rid of rattles while landed

0.1.2-0.90 | 04-03-2015
- Added Configuration Options

0.1-0.90 | 04-03-2015
- Release Version
- new sound loops
- Added layers of sound
- added engine thrust response

Thank you to Ensou for creating the mod, and CoriW and Fwiffo for maintaining the mod and notletting it slip into obscurity! Without you guys this continuation couldn't be possible.

=========
LICENSING
=========

The contents of this pack are distributed under a Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (http://creativecommons.org/licenses/by-nc-sa/4.0/).

You are free to share and adapt the materials only for non-commercial purposes and when providing appropriate attribution. Any derivatives must be distributed under the same license. 

