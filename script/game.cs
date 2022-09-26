using Godot;
using System;

public partial class game : Node2D
{
	[Export]
	public Node2D knifeHolder;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _Input(InputEvent @event)
	{
		if(@event.IsActionReleased("click"))
		{
			if(knifeHolder != null)
			{
				knifeHolder.GetChild(0).Set("thrown", true);
			}
		}
	}
}
