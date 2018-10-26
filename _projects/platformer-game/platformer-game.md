---
title: Platformer Game
subtitle:
layout: project
submission-id: YOURNAME-game-project
asset-path: /assets/exercise-images
asset-downloads: /assets/exercise-downloads
project: project-2
---
## Description

In the project, we will use Photoshop and Unity as tools to respond to either: (1) a real world "Wicked Problem"; or (2) an existing fictional story that interests you. If choosing a fictional story, avoid stories that already exist as games.

## Learning Resources

**Reading**

- [Wicked Problem](https://hackernoon.com/design-thinking-and-wicked-problems-9265c14fe8e4)
- [Braid Game by Jonathan Blow](https://www.youtube.com/watch?v=QxXkcg-stLE)

**Unity:**

- [How to make a 2D Platformer Part 1](https://www.youtube.com/watch?v=UbPiCgCkHTE)
- [How to make a 2D Platformer Part 2](https://www.youtube.com/watch?v=zwNGjS_1Lxk)
- Lynda: [2D Unity Essentials](https://www.lynda.com/Games-tutorials/Unity-5-2D-Essential-Training/494386-2.html?org=psu.edu)

**Making sprites**

- [Making a sprite grid](https://www.youtube.com/watch?v=8x1dh3TDnss)

**Walk cycle animation**

- [How To Pixel Art Tutorials [17] - Walk Cycle (6 & 8 frames)](https://www.youtube.com/watch?v=5QTCwiJUmmo)
- [Walk Cycle Animation](https://www.youtube.com/watch?v=2y6aVz0Acx0)

**Example art**

- [2D Mega Pack](http://devassets.com/assets/2d-mega-pack/)

## Requirements

1. Create all work in the 2D game yourself, do not download or trace other artwork.
2. Game must be comprised of an animated sprite character. The character does not have to be human.
3. Sprite Sheet: Min of 4 poses in the walk cycle: Contact, up, passsing, and down in the 'right' \(→\) direction.

## Tutorial

### Set up character move and jump:

#### [Unity Downloads]({{site.baseurl}}{{page.asset-downloads}}/unity-demo.zip)
#### [Example scene configuration images]({{site.baseurl}}{{page.asset-downloads}}/unity-scene-setup.zip)

1. Create 2D Unity project.
2. Drag character 'walk cycle' and "environment" PSD sprites files.
3. Drag the walk cycle sprite file to the scene **Hierarchy** tab.
4. With the object selected in the assets view, Select **multiple** from the Sprite Mode and then open the **sprite editor.**
5. Click on **slice** in top left. Choose automatic or use the cell size you’ve previously prepared (34px in this example). This will create an animated sprite in your assets tab.
6. Set the size of the sprite (34 pixels in my case).
7. Create a Create GameObject → EmptyChild in the Hierarchy and rename to **player.**
8. Drag the sprite walk sequence object onto the player object in the Hierarchy so it is parented to the the player object. Rename to **playerWalking**.
9. Select the player → Add Component and choose **Box Collider 2d.**
10. Scale the box to fit over the top half of the sprite
11. With player selected, Add a **Circle Collider 2d,** scale to fit below the box covering the bottom of the sprite
12. With player selected, Add **rigidbody 2D.**
    - Check lock rotation under constraints
13. Create GameObject → EmptyChild and parent this to the player object.
14. Rename to **GroundCheck** and reposition at bottom of character sprite (click on icon to add a color)
15. Add **player_jump**"** script to the player object.
16. Drag **groundCheck** from Scene Hierarchy to **player_jump** slot called "GroundCheck" to connect them.
17. On **player_jump** script properties, set ground as **everything,** and then **uncheck "Player."** It should now say **Mixed.**
18. With the player object selected, at the top choose layer and add two layers (“Player”, “Ground”, and "Background").
19. Set the character and children to “Player” layer (located at the top of the object properties).
20. Add a ground sprite to the scene.
21. Add a **box collider 2d** component to the ground object.
22. Set the ground assets objects to “Ground” and the background assets to the "Background" layer. Change **Order in Layer** to -1 or higher to move objects visibly below the player.
23. Adjust the framing of the game by adjusting main camera size. This is dependent.

#### Adding Animation to sprite 

1. Select parented **playerWalking** object (not the **player** object) object in hierarchy. 
2. Add a new **animator** component
3. Drag the **player_animation** script to this object
4. Open the animation window (Window → Animation)
5. In Animation window, click "Create new"
6. Unfurl the walk cycle in the assets window, and select all walk cycle sprites. Drag them into the animation window
7. Change player animation samples to match your walk cycle and move speed  (between 8 to 24 ish)

#### Adding audio 

1. Create audio source object (Right click, Audio → Audio Source) to the hierarchy.
2. Drag **audio_script** from assets onto AudioSource object in the hierarchy.
3. Drag the mp3 or other formatted audio file from assets into **music clip** slot.
4. Drag the "AudioSource" object from hierarchy into **music source** slot.

#### Building
1. Export to a MacOS File by choosing: File → Build settings
2. Choose  → macos → ensure scene is added to the build

### Set up camera

1. open/import 2d standard assets.
2. drag camera2Dfollow script onto camera
3. drag player into target field of script

### Video Resources

- [moving script](https://www.youtube.com/watch?v=Rr4sE_A_E-Q)
- [flip left and right script](https://www.youtube.com/watch?v=y7IJsnKR120)
- [jump script](https://www.youtube.com/watch?v=Kvje4xqB258)
- [adding audio](https://www.youtube.com/watch?v=egxNXuwf0_g)


## Due dates:

- **Oct 19 at 2:30pm:** [Project concept Dropbox](https://psu.instructure.com/courses/1913414/assignments/10430505)
- **Oct 19 at 2:30pm:** [Sprite Sheet Dropbox](https://psu.instructure.com/courses/1913414/assignments/10427548)
- **Oct 26 at 2:30pm:** [Environment Assets Dropbox](https://psu.instructure.com/courses/1913414/assignments/10430256)
- **Nov 2 at 2:30pm:** [Functional Unity Project Proof (video) Dropbox](https://psu.instructure.com/courses/1913414/assignments/10430362)
- **Nov. 9 at 2:30pm:** [Finished Game Dropbox](https://psu.instructure.com/courses/1913414/assignments/10347037) 

## Submission Instructions

1. Watch learning resources for building a 2D Unity game and assets.
1. Identify a project concept based on a fictional book, or story, or a wicked problem currently affecting the world.
   - Submit in .txt or .doc format
   - [Project concept Dropbox](https://psu.instructure.com/courses/1913414/assignments/10430505)
2. Produce a sprite sheet of a character walk cycle using Photoshop
   - Minimum 4 poses (contact, passing, contact, passing). Can have more than 4, see videos in learning resources.
   - Upload PSD character sprite sheet to Canvas.
   - [Sprite Sheet Dropbox](https://psu.instructure.com/courses/1913414/assignments/10427548)
4. Produce a sprite sheet of environment assets using Photoshop
   - Upload PSD environment assets to Canvas.
   - [Environment Assets Dropbox](https://psu.instructure.com/courses/1913414/assignments/10430256)
5. Upload a video (captured with Quicktime) of your Unity project
   - Create a Quicktime video screen capture working game prototype. (Character walk cycle moving across environment asset)
   - [Functional Unity Project Proof (video) Dropbox](https://psu.instructure.com/courses/1913414/assignments/10430362)
6. Upload Zipped Unity project file.
   - Zip file that includes an executable
   - [Finished Game Dropbox](https://psu.instructure.com/courses/1913414/assignments/10347037)