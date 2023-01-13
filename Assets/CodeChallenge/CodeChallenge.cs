using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeChallenge : MonoBehaviour
{
    private float horizontal;

    private float vertical;



    // Create a variable to store the speed of the character
int speed = 10;

    void Start()
    {

    }


    void Update()
    {
        Vector2 position = transform.position;
        horizontal = Input.GetAxis("Horizontal");
     vertical = Input.GetAxis("Vertical");


        // Update the speed of the horizontal movement to be dynamic instead of the static 10 value
        position.x = position.x + speed * horizontal * Time.deltaTime;
         position.y = position.y + speed * vertical * Time.deltaTime;


        transform.position = position;

        
    }

   

}
