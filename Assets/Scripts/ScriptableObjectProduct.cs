using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoxType
{
    Classic,
}

[System.Serializable]
public class Vegetables
{
    public List<Transform> VegetablesSpoiledSprite = new List<Transform>();
    public List<Transform> VegetablesSprite = new List<Transform>();
}

[System.Serializable]
public class Products
{
    public List<Transform> ProductSpoiledSprite = new List<Transform>();
    public List<Transform> ProductSprite = new List<Transform>();
}


[CreateAssetMenu(menuName = "SpriteFood", fileName = "Food")]
public class ScriptableObjectProduct : ScriptableObject
{
    public List<Sprite> TaskList = new List<Sprite>();
    public List<Vegetables> VegetablesSprites;
    public List<Products> ProductsSprites;
}