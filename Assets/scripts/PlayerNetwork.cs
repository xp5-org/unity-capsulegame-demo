using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    // Start is called before the first frame update
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float movement = Input.GetAxis("Vertical");
            movement *= Time.deltaTime;

            float sideStep = Input.GetAxis("Horizontal");
            sideStep *= Time.deltaTime;

            if (this.GetComponent<Rigidbody>().
                velocity.magnitude < 5f)
            {
                this.GetComponent<Rigidbody>().AddForce
            (this.transform.forward * movement * 1000f);
            }


            this.transform.Translate
            (Vector3.right * sideStep * 3f);
            this.transform.Translate
            (Vector3.forward * movement * 3f);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                // jumpKeyWasPressed = true;
                GetComponent<Rigidbody>().AddForce(Vector3.up * 3, ForceMode.VelocityChange);
                GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);
            }
        }
    }

    void Update()
    {
            HandleMovement();
    }
}
