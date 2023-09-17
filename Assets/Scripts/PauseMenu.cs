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
	
	public void OnQuitButtonPressed() {
		GetTree().ChangeSceneToFile("res://Assets/Scenes/MainMenu.tscn");
		GetTree().Paused = false;
	}

	public void Unpause() {
		animator.Play("Unpause");
	}

	public void Pause() {
		GetTree().Paused = true;
		animator.Play("Pause");
	}

	public void OnAnimationFinished(string animName) {
		if (animName == "Unpause") {
			Input.MouseMode = Input.MouseModeEnum.Captured; 
			GetTree().Paused = false;
		} else if (animName == "Pause") {
			Input.MouseMode = Input.MouseModeEnum.Visible;
		}
	}
}
