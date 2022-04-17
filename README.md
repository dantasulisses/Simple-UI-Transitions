# Simple UI Transitions

Simple UI Transitions is a small package that wraps simple animation behaviours usually needed in UI, like doing Show and Hide behaviour.


<p align="center">
    <a href="https://unity3d.com/get-unity/download">
        <img src="https://img.shields.io/badge/unity-tools-blue" alt="Unity Download Link"></a>
    <a href="https://github.com/dantasulisses/Simple-UI-Transitions/blob/main/LICENSE.md">
        <img src="https://img.shields.io/badge/License-MIT-brightgreen.svg" alt="License MIT"></a>
</p>


## Table of Contents
- [How it works](#How-it-works)
- [Installation](#Installation)
- [Features](#Features)
- [Support](#Support)
- [Thanks](#Thanks)
- [License](#License)


## How it works

Instead of manually controlling which elements are currently being shown on the screen or not, and writing the same Tween functions in reverse, just add one of the Transition components and from your code call:
```csharp
    //Make the transition enter/exit
    someTransition.DoTween(true/false);
    //Toggle the object transition (quits if has entered; enters if has not)
    someTransition.ToggleState();
    //Change the object to it's transition end state, without doing the animation/tween
    someTransition.SetState(true/false);
```



## Installation

Simple UI Transitions can be installed directly through the git url
```
https://github.com/dantasulisses/Simple-UI-Transitions.git
```

If you need more information about installing package from a Git URL, you can click [here](https://docs.unity3d.com/Manual/upm-ui-giturl.html). :slightly_smiling_face:

Simple UI Transitions is also the base for another package, the Simple UI Controller (link)


## Dependencies

Simple UI Transitions uses the free DoTween package as the base for the Tweening actions.
DoTween will NOT be automatically installed by Simple UI Transitions to avoid problems with colliding package names. 
More information about DoTween can be found here: http://dotween.demigiant.com/index.php

Also, Simple UI Transitions has some useful In-Editor-Buttons for turning transitions on and off, along with creating positions references; These are only available if you have OdinInspector (http://dotween.demigiant.com/index.php) in your project


## Features

Currently, this is what Simple UI Transitions does have
| Features                                                     |       Status      |
| ------------------------------------------------------------ | :----------------:|
| CanvasGroupTransition (Alpha, Block Interaction)             |         ✔️        |
| MoveTransition                                               |         ✔️        |
| ScaleTransition                                              |         ✔️        |
| GroupTransition (Execute several Transitions simultaneously) |         ✔️        |
| Animator Transition (Turn on/off a Animator boolean)         |         ✔️        |



## Support
Please submit any queries, bugs or issues, to the [Issues](https://github.com/dantasulisses/Simple-UI-Transitions/issues) page on this repository. All feedback is appreciated as it not just helps myself find problems I didn't otherwise see, but also helps improve the project.


## Thanks
My friends and family, and you for having come here!


## License
Copyright (c) 2021-present Ulisses Dantas and Contributors. Simple UI Transitions is free and open-source software licensed under the [MIT License](https://github.com/dantasulisses/Simple-UI-Transitions/blob/main/LICENSE.md).