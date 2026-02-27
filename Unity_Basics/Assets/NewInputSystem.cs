using UnityEngine;

public class NewInputSystem : MonoBehaviour
{
    public CustomInputActionMap input;
    private bool attackHeld = false;

    private void Start()
    {
        input = new CustomInputActionMap();
    }

    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }

    private void AttackPressed(InputAction.CallbackCOntext _) => Debug.Log("ATTACK PRESSED");

    private void AttackReleased(InputAction.CallbackCOntext _)
    {
        attackHeld = false;
        Debug.Log("ATTACK RELEASED");
    }

    private void Start()
    {
        input = new CustomInputActionMap();

        input.Player.Attack.performed += AttackPressed;
        input.Player.Attack.started += _ => attackHeld = true;
        input.Player.Attack.canceled += AttackReleased;
    }
}
