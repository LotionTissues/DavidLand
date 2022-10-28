using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawgRidaa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float horizontal2 = Input.GetAxis("horizontal2");
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal2;


        float vertical2 = Input.GetAxis("vertical2");

       
        position.y = position.y + 0.1f * vertical2;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
