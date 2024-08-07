using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gameManager;
    public FoodData.FoodType foodType;
    //private int value;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<FoodIdentifier>().foodType == foodType)
        {
            gameManager.AddScore(1);
            Destroy(collision.gameObject);
        }
        else
        {
            gameManager.AddLives(-1);
            Destroy(collision.gameObject);
        }

    }

}

#if UNITY_EDITOR

#endif