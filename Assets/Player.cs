using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
   public float Speed = 10f;
   public float JumpPower = 5f;
  
   private Rigidbody2D _rb;


   // Start is called before the first frame update
   void Start()
   {
       _rb = GetComponent<Rigidbody2D>();   
   }


   // Update is called once per frame
   void Update()
   {
       var horizontal = Input.GetAxis("Horizontal");
       if (Input.GetAxis("Horizontal") != 0)
       {
           transform.Translate(horizontal * Speed * Time.deltaTime * Vector2.right);
       }
      
       if (Input.GetButtonDown("Jump"))
       {
           _rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
       }
   }
}
