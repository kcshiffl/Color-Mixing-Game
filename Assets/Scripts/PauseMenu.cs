using Godot;
using System;

public partial class PauseMenu : ColorRect {

	public AnimationPlayer animator;
	public Button playButton;
	public Button quitButton;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		animator =  GetNode<AnimationPlayer>("AnimationPlayer");
		playButton = GetNode<Button>("PlayButton");
		playButton = GetNode<Button>("QuitButton");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}

	public void OnResumeButtonPressed() {
		// GetTree().ChangeSceneToFile("res://Assets/Scenes/ColorPickerScene.tscn");
	}

	public void OnQuitButtonPressed() {
		GetTree().ChangeSceneToFile("res://Assets/Scenes/MainMenu.tscn");
	}

	public void Unpause() {
		animator.Play("Unpause");
		GetTree().Paused = false;
		Input.MouseMode = Input.MouseModeEnum.Captured; 
	}

	public void Pause() {
		animator.Play("Pause");
		GetTree().Paused = true;
		Input.MouseMode = Input.MouseModeEnum.Visible; 
	}
}
