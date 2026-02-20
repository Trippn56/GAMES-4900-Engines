using UnityEngine;

public class Caller : MonoBehaviour

{
    public Receiver receiver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Hello Friend");
        receiver.OnCalled();
    }
}
