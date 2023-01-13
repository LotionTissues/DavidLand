using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurryController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    public int maxHealth = 5;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    
     {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

   void FixedUpdate() 
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 5f * horizontal * Time.deltaTime;
       
        position.y = position.y + 5f * vertical * Time.deltaTime;
       rigidbody2d.MovePosition(position);
        
    }

    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }



}
