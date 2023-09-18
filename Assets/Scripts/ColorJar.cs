using Godot;
using System;

public partial class ColorJar : MeshInstance3D {
	Color currentColor;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		currentColor = new Color(1f, 1f, 1f);
		changeColor(currentColor);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}

	private void changeColor(Color newColor) {
		currentColor = newColor;
		StandardMaterial3D material = (StandardMaterial3D)this.GetSurfaceOverrideMaterial(0);
		material.AlbedoColor = newColor;
		this.SetSurfaceOverrideMaterial(0, material);
	}

	public void AddColor(Color addedColor, double amount) {
		float diff;
		Color newColor = currentColor.Lerp(addedColor, (float)amount);
		changeColor(newColor);
	}
}
