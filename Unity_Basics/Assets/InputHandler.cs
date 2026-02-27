using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private bool attackHeld;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackHeld = true;
            Debug.Log("Attack pressed");
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            attackHeld = false;
            Debug.Log("Attack released");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) Debug.Log("Attack held");

        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.A)) x -= 1f;
        if (Input.GetKey(KeyCode.D)) x += 1f;
        if (Input.GetKey(KeyCode.S)) y -= 1f;
        if (Input.GetKey(KeyCode.W)) y += 1f;

        Vector3 move = new Vector3(x, y, 0);
        if (move != Vector3.zero)
        {
            Debug.Log($"MOVE {move}");

            transform.position += move * 0.01f;
        }


    }

}
