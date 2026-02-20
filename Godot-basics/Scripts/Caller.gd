extends Node3D

class_name Caller

@export var receiver: Node3D

func _ready():
	print("Hello Friend")
	receiver.OnCalled()
