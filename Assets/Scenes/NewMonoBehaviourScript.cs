using UnityEngine;
using UnityEngine.InputSystem;
public class AngularVelocity : MonoBehaviour
{
    public float angularSpssd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()

    {   
        // Press 'A' to Rotate using using Angular Velocity
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularSpssd, 0); 
        }
        

    }
}
