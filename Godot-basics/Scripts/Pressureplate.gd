extends Area3D

class_name PreasurePlate

func _ready() -> void:
	body_entered.connect(_on_body_entered)
	
func _on_body_entered(body):
	if body.is_in_group("Player"):
		print("Playerentered 3D Trigger")
	
