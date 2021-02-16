using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    // Start is called before the first frame update
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float movement = Input.GetAxis("Vertical");
            movement *= Time.deltaTime;

            float sideStep = Input.GetAxis("Horizontal");
            sideStep *= Time.deltaTime;

            //		this.transform.Translate
            //		(Vector3.forward * movement);

            if (this.GetComponent<Rigidbody>().
                velocity.magnitude < 5f)
            {
                this.GetComponent<Rigidbody>().AddForce
            (this.transform.forward * movement * 1000f);
            }

            this.transform.Translate
            (Vector3.right * sideStep);
            //  float moveHorizontal = Input.GetAxis("Horizontal");
            //  float moveVertical = Input.GetAxis("Vertical");
            //  Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
            //  transform.position = transform.position + movement;
        }
    }

    void Update()
    {
            HandleMovement();
    }
}
