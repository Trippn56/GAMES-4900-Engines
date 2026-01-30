extends Node3D

class_name ActivatorClass

@export var HelloComponent: Greeter


func _ready() -> void:
	if HelloComponent == null:
		push_warning("No Greeter assigned")
		return
	
	pass


func _unhandledloop(event: InputEvent) -> void:
	if event is InputEventKey and event.pressed
func _process(delta: float) -> void:
	
	pass
