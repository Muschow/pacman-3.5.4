using Godot;
using System;

public class GhostScript : CharacterScript
{
    protected AnimatedSprite ghostEyes;
    protected override void MoveAnimManager(Vector2 masVector)
    {
        //animatedSprite = GetNode<AnimatedSprite>("AnimatedSprite"); //not sure whether to put it in here for readabillity or in each ready so theres less calls
        //ghostEyes = GetNode<AnimatedSprite>("GhostEyes"); //not sure whether to put it in here for readabillity or in each ready so theres less calls
        masVector = masVector.Normalized();
        if (masVector == Vector2.Up)
        {
            ghostEyes.Play("up");
        }
        else if (masVector == Vector2.Down)
        {
            ghostEyes.Play("down");
        }
        else if (masVector == Vector2.Right)
        {
            ghostEyes.Play("right");
        }
        else if (masVector == Vector2.Left)
        {
            ghostEyes.Play("left");
        }
    }
    //As GhostScript is a base class, it will not be in the scene tree so ready and process are not needed
    // Called when the node enters the scene tree for the first time.
    // public override void _Ready()
    // {

    // }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
