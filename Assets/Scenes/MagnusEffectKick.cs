using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusEffectKick : MonoBehaviour
{
    public float kickForse;
    public float spinAmount;
    public float magnusStrength = 0.7f;

    Rigidbody rb;
    bool isShot=false;
    void Start()

    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Perss Space to kick ball
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isShot);
        {
            rb.AddForce(Vector3.forward * kickForse, ForceMode.Impulse );

            rb.AddTorque(Vector3.up * spinAmount);
            isShot =true;
        }
    }

    
    void FixedUpdate()
    {
        if (!isShot) return;

        Vector3 velocity =rb.linearVelocity;
        Vector3 spin=rb.angularVelocity;

        Vector3 magnusForce = magnusStrength * Vector3.Cross(spin, velocity);
        rb.AddForce(magnusForce);
    }
}
