using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    private Rigidbody2D myBody;
    private float jumpForce = 5f;

	void Awake () {
        myBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Jump();
	}

    void Jump() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            myBody.velocity = new Vector2(myBody.velocity.x, jumpForce);
        }
    }

	void OnTriggerEnter2D(Collider2D target) {
		
        if(target.tag == "Knife") {
            Time.timeScale = 0f;
        }

	}


}
