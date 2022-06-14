<p align="center">
  <img width="300" src="./repo-assets/arcade-s.png" style="margin-bottom: 5rem;">
</p>


# Unity SDK for the Research Arcade 
This is a small SDK to help build games targetting the Research Arcade platform. The Research Arcade platform runs games via WebGL, so please switch your project to WebGL before building. This SDK helps in two main ways:

- Providing input bindings and methods to check for player input on the arcade machines, making building interactive experiences easy.
- Offering methods to perform native navigation easy, such as returning to the arcade's main menu rather than exiting a game.

## Notes before you get started
Using the SDK requires that you have at least some knowledge of Unity and how to import libraries into your project. Furthermore, if you haven't already read the development guide, please do so. It will give you a better understanding of how the software & hardware of the arcade cabinets work.



## Versions

| Version | Date | Notes | 
|----|----|----|
| `v1.0.0` | 14/06/22 | First initial release


# Quick Start
To get started, download the latest release from the releases page of this repository. Then, import it directly into your project by double clicking it or using **Assets > Import Package > Custom Package**. Importing is that easy.

The classes within the SDK reside in the namespace `ResearchArcade`. When you want to use the SDK in your project, make sure that you either explicitly reference this namespace, or use the `using` statement to reference it like so:

```cs
//Use the SDK
using ResearchArcade;

//...
```

There are two main functionalities of this SDK, namely handling user input from the arcade, and providing native navigation. We'll discuss input first.

## Checking for input
Input can achieved primarily through the aptly named `ArcadeInput` class. The class provides two static keymaps for player 1 and player 2, which can be accessed through `ArcadeInput.Player1` and `ArcadeInput.Player2`. This makes it super easy to detect player input for each player, like so:

```cs
//Player 1 just pressed the A button:
if(ArcadeInput.Player1.A.Down)
    character.Jump();

//Player 2 just released the start button:
if(ArcadeInput.Player2.Start.Up)
    game.Start();
```

Each player has a total of 6 general-purpose buttons, namely the `A`, `B`, `C`, `D`, `E` and `F` buttons. Each player has a `Start` button they can press too, along with `JoyUp`, `JoyDown`, `JoyLeft` and `JoyRight` directional buttons for each joystick. Each of these buttons is called a `Binding` in the API, as it binds a joypad button to a key press.

Each binding has three fields to detect the state of input:

- `Down`, which internally uses `Input.GetKeyDown(...)`, to detect if the button was just pressed.
- `Up`, which internally uses `Input.GetKeyUp(...)`, to detect if the button was just released.
- `HeldDown`, which internally uses `Input.GetKey(...)`, to detect if the button is being held down.

There is also `ArcadeInput.Exit` for the two quit buttons on the cabinet. With this in mind, you can check for any input in an abstract fashion, without having specific key presses in mind. The following is some examples of checking for input using the SDK.

### **Example 1: Checking directional input for Player 2**
```cs
//Left held down? Move the character left
if(ArcadeInput.Player2.JoyLeft.HeldDown)
    player.MoveLeft();

//Right held down? Move the character right
else if(ArcadeInput.Player2.JoyRight.HeldDown)
    player.MoveRight();

//---

//Up held down? Move the character up
if(ArcadeInput.Player2.JoyUp.HeldDown)
    player.MoveUp();

//Down held down? Move the character down
else if(ArcadeInput.Player2.JoyDown.HeldDown)
    player.MoveDown();
```

### **Example 2: Logging A button for Player 1**
```cs
if(ArcadeInput.Player1.A.Down)     Debug.Log("Player 1, A: Down");
if(ArcadeInput.Player1.A.Up)       Debug.Log("Player 1, A: Up");
if(ArcadeInput.Player1.A.HeldDown) Debug.Log("Player 1, A: HeldDown");
```

## Arcade navigation
Another functionality of this SDK is to provide developer access to native navigation methods for the arcade. For example, when the player presses the exit button -- the game should return back to the main menu. But how would you do this from within a Unity game? The answer is to use the `Navigation` class to do so. It is as simple as calling the `ExitGame()` method, like so:

```cs
//The exit button has been pressed, exit to the main menu
if(ArcadeInput.Exit.Down)
    ResearchArcade.Navigation.ExitGame();
```

Notice that the full namespace is qualified in invokation here, this is to eliminate ambiguity between `UnityEngine.UI.Navigation` and `ResearchArcade.Navigation`. 
