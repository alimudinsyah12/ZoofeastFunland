using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner: MonoBehaviour
{
    public FoodData[] foods;
    private FoodData selectedFood;
    public SpriteRenderer selectedFoodSprite;
    // Start is called before the first frame update
    void Start()
    {
        RandomizeFood();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FoodSpawn()
    {
        
        Vector3 spawnPos = new Vector3(-6, 0, 0);
        Instantiate(selectedFood.projectilePrefab, spawnPos, transform.rotation);
        RandomizeFood();

    }

    private void RandomizeFood()
    {

        selectedFood = foods[Random.Range(0, foods.Length)];
        selectedFoodSprite.sprite = selectedFood.foodSprite;
    }
}
