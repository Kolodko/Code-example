using System.Collections.Generic;
using System.Collections;
using UnityEngine;

[System.Serializable]
public class Vegetables
{
    public List<Sprite> VegetablesSpoiledSprite = new List<Sprite>();
    public List<Sprite> VegetablesSprite = new List<Sprite>();
}

[System.Serializable]
public class Products
{
    public List<Sprite> ProductSpoiledSprite = new List<Sprite>();
    public List<Sprite> ProductSprite = new List<Sprite>();
}

[CreateAssetMenu(menuName = "SpriteFood", fileName = "Food")]
public class ScriptableObjectProduct : ScriptableObject
{
    public List<Sprite> TaskList = new List<Sprite>();
    public Vegetables VegetablesSprites;
    public Products ProductsSprites;
}