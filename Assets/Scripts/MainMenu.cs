using Godot;
using System;

public partial class MainMenu : ColorRect
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}

	public void OnPlayButtonPressed() {
		GetTree().ChangeSceneToFile("res://Assets/Scenes/ColorPickerScene.tscn");
		Input.MouseMode = Input.MouseModeEnum.Captured; 
	}

	public void OnQuitButtonPressed() {
		GetTree().Quit();
	}
}
