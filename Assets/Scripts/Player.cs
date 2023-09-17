using Godot;
using System;

public partial class Player : Node3D {

	PauseMenu pauseMenu;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		pauseMenu = GetNode<PauseMenu>("PauseMenu");
	}

	public override void _Process(double delta) {
		if(Input.IsPhysicalKeyPressed(Key.Escape)) {
			pauseMenu.Pause();
		}
	}
}
