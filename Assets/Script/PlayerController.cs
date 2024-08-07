using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float rotateSpeed = 25.0f;
    public static PlayerController instance;
    public FoodSpawner foodSpawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //player rotate
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.back * Time.deltaTime * rotateSpeed * horizontalInput);
        
        
        //player shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {

            foodSpawner.FoodSpawn();

        }
        
    }

}
