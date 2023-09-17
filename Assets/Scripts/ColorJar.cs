using Godot;
using System;

public partial class ColorJar : MeshInstance3D {
	string colorEdit;
	Color currentColor;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		currentColor = new Color();
		changeColor(currentColor);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}

	private void changeColor(Color newColor) {
		StandardMaterial3D material = (StandardMaterial3D)this.GetSurfaceOverrideMaterial(0);
		material.AlbedoColor = newColor;
		this.SetSurfaceOverrideMaterial(0, material);
	}

	public void AddColor(Color addedColor) {
		Color newColor = currentColor;
		newColor = addedColor;
		changeColor(newColor);
	}
}