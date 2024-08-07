using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "FoodData", menuName = "FoodGenerator/FoodData", order = 1)]
public class FoodData : ScriptableObject
{
    public enum FoodType
    {
        Herbivora,
        Karnivora,
        Omnivora
    }

    public GameObject projectilePrefab;
    public Sprite foodSprite;
}
