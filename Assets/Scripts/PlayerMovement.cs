using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sideForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void Update() {
        if(Input.GetKey("d")) {
            rb.AddForce(sideForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(-sideForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
