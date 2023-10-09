using Godot;
using System;

public partial class ColorPickerScene : Node3D
{
	PauseMenu pauseMenu;
	VSlider paintSlider;
	Node3D jar;
	Node3D currentHoverColor;
	Godot.Collections.Array colors;
	Label paintAmountLabel;
	ColorJar currentColor;

	private int color = 2;
	private int paintAmount = 50;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		pauseMenu = GetNode<PauseMenu>((NodePath)GetMeta("PauseMenu"));
		paintSlider = GetNode<VSlider>((NodePath)GetMeta("PaintSlider"));
		paintAmountLabel = GetNode<Label>((NodePath)GetMeta("PaintAmountLabel"));
		jar = GetNode<Node3D>((NodePath)GetMeta("ColorJar"));
		colors = (Godot.Collections.Array)(GetMeta("Colors"));
		currentColor = GetNode<ColorJar>((NodePath)GetMeta("ColorJarPaint"));

		paintSlider.Value = paintAmount;
	}

	public override void _Process(double delta) {
		if (Input.IsActionJustPressed("Escape")) {		// Pause Menu
			pauseMenu.Pause();
		} else if (Input.IsActionPressed("Shift")) {	// Increase paint amount
			if (Input.IsActionJustPressed("Up"))  {
				paintSlider.Value+=5;
			} else if (Input.IsActionJustPressed("Down")) {
				paintSlider.Value-=5;
			}
		} else if (Input.IsActionJustPressed("Up")) {	// Decrease paint amount
			paintSlider.Value++;
		} else if (Input.IsActionJustPressed("Down")) {	// Decrease paint amount
			paintSlider.Value--;
		} else if (Input.IsActionJustPressed("Left")) {	// Move Left
			color = color > 0 ? color-1 : 0;
		} else if (Input.IsActionJustPressed("Right")) { // Move right
			color = color < 7 ? color+1 : 7;
		} else if (Input.IsActionJustPressed("Enter")) { // Add paint
			Color addedColor = ((PaintTubeColor)(currentHoverColor.GetNode("Color"))).color;
			currentColor.AddColor(addedColor, paintSlider.Value*.01);
		}

		currentHoverColor = GetNode<Node3D>((string)colors[color]);
		jar.Position = new Vector3(currentHoverColor.Position.X, jar.Position.Y , jar.Position.Z);
		paintAmountLabel.Text = paintSlider.Value + "%";
	}

	private void moveJarPosition() {
		
	}
}
