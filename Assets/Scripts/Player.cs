using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float _speed = 5.5f;
    public float _Rspeed = 1.5f;
    private float _turn = 0;

    // Start is called before the first frame update
    void Start()
    {
        // (step:1) Taking the initial position and tranforming to = new position (0,0,0) everytime game starts
        transform.position = new Vector3(1, 1.5f,  15);  
        
        
        
    }

    // Update is called once per frame
    void Update()
    {



        float horizontalInput = Input.GetAxis("Horizontal");

        //Defining movement controls here


        transform.position += new Vector3(0, 0, 1) * Time.deltaTime * _speed * horizontalInput;

      
        transform.Rotate(0, -1, 0 * _turn * Time.deltaTime * _Rspeed);

        transform.rotation = new Quaternion(Quaternion.identity.x, Quaternion.identity.y, 0, 0) ;
        
        





    }
}
