using Godot;
using System;

public partial class knife : Node2D
{
	[Export]
	public float speed;
	[Export]
	public bool thrown;

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		if (thrown)
		{
			var pos = GlobalPosition;
			pos.y += speed;
			GlobalPosition = pos;
		}
	}
	private void _on_area_2d_area_entered(Area2D area)
	{
		if (area.Name.Equals("Center"))
		{
			var _prevPos = GlobalPosition;
			thrown = false;
			GetParent().RemoveChild(this);
			area.GetNode("knifes").AddChild(this);
			GlobalPosition = _prevPos;
			//Rotation = Godot.Mathf.DegToRad(290f);

			GetChild<Area2D>(0).Monitoring = false;
		}
	}
}
