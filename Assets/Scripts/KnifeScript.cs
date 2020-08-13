using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{

    public bool moveRight;
    private float speed = 2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {

        if(moveRight) {

            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;

        } else {

            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;

        }


    }

}
