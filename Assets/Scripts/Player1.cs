using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   //public Rigidbody2D rb;
    
    public float speed;
    public Transform leftBorder;
    public Transform rightBorder;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(1, 0) * speed * Time.deltaTime;

        //Vector2 worldBoundary = Camera.main.ScreenToWorldPoint( new Vector2( Screen.width, Screen.height ));
        //print(worldBoundary.x);
        int screenWidth = Screen.width;

        if(Input.mousePosition.x>screenWidth-screenWidth/4 && transform.position.x <rightBorder.position.x){
           // rb.AddForce(movement);
           Vector3 pos = transform.position;//transform.position vektorunun değerleri ayrı ayrı modifiye edilemez
           pos.x += speed * Time.deltaTime;
           transform.position = pos;
           //transform.position.x değişiremiyorsun, atama yok
        }
        if(Input.mousePosition.x<screenWidth/4 && transform.position.x >leftBorder.position.x){
           // rb.AddForce(-movement);
           Vector3 pos = transform.position;
           pos.x -= speed * Time.deltaTime;
           transform.position = pos;
        }



        
    }
}
