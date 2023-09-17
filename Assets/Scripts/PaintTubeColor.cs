using Godot;
using System;

public partial class PaintTubeColor : MeshInstance3D {
	public Color color;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		color = (Color)GetMeta(GetParent().Name);
		StandardMaterial3D material = new StandardMaterial3D();
		material.AlbedoColor = color;
		this.SetSurfaceOverrideMaterial(0, material);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}
}
