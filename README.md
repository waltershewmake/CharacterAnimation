# CharacterAnimation
## A basic Unity Package I created which adds some basic character animation to my games.

Using this package, I can easily import an animated character to basic mobile games, significantly reducing the time it takes to finish a game. This is just a basic skeleton and can be easily added upon.

I plan to use this in the future to fulfill my "Make a game in 1 hour every day for a month" challenge.

# Instructions

To use, simply run the `CharacterMovement.unitypackage` file, and import everything. You can skip the "Demo" folder if you would like.

Then you can drag in the Character prefab to your scene. To change the animation state, I added a `SetState` method, which can be called like so:

```C#
...

/*
Walking: <0
Idle: 0
Walking: 1
Running: >1
*/
int _state = 0;

CharacterAnimator.instance.SetState(_state);
...
```

Alternatively, you can use the builtin static methods `SetIdle()`, `SetWalking()`, `SetWalkingBackwards()`, and `SetRunning()` like so:

```C#
...
CharacterAnimator.SetIdle(); //idle state
CharacterAnimator.SetWalking(); //walking state
CharacterAnimator.SetWalkingBackwards(); //walkikng backwards state
CharacterAnimator.SetRunning(); //running state
...
```

# Demo Movement Controller

## This is how the demo controller uses the provided methods

Note that there are far better ways to make a player movement controller. This is just a proof of concept for the animations.

```C#
void Update()
    {
        //sprinting
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w")) {
            CharacterAnimator.SetRunning();
        }
        //walking
        else if (Input.GetKey("w")) {
            CharacterAnimator.SetWalking();
        }
        //walking backwards
        else if (Input.GetKey("s")) {
            CharacterAnimator.SetWalkingBackwards();
        }
        //idle
        else {
            CharacterAnimator.SetIdle();
        }
    }
```

# Future plans

If I edit this in the future, I plan to add some strafing and sideways walking movements.
