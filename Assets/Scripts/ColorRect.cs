using Godot;
using System;

public partial class ColorRect : Godot.ColorRect {

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		this.Color = Color.FromHsv(
			// this.Color.H+0.0005f, 
			this.Color.H * (float)(new Random().NextDouble()),
			this.Color.S, 
			this.Color.V
		);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		this.Color = Color.FromHsv(this.Color.H+0.0005f, this.Color.S, this.Color.V);
	}
}
