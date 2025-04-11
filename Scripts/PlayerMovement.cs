using Godot;
using System;

public partial class PlayerMovement : Sprite2D
{
    // public void Test() => {GD.Print("Hello, world!");}
    private float _rotationSpeed = 1.0f;
    private float _movementSpeed = 500f;
    private int _direction = 0;

    public override void _Process(double delta)
    {
        // Rotation += (float)delta * _rotationSpeed;

        if (Input.IsActionPressed("ui_left"))
        {
            _direction = -1;
        }
        else if (Input.IsActionPressed("ui_right"))
        {
            _direction = 1;
        }
        else
        {
            _direction = 0;
        }

        // 左右移动
        Position += new Vector2(_direction * _movementSpeed * (float)delta, 0);
    }


}
