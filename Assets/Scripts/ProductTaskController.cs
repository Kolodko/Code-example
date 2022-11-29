using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ProductTaskController : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> _taskProdyct = new List<SpriteRenderer>();
    [SerializeField] private ScriptableObjectProduct _scriptableObject;
    private List<int> _number = new List<int>() { 0, 0, 0, 0, 0 };
    private int _randomNumber;

    private void RandomNumber(int countnRandom, int number)
    {
        _randomNumber = Random.Range(0, countnRandom);
        for(int i = 0; i < _number.Count; i++)
        {
            if(_number[i] == _randomNumber) {SpawnTaskProduct();}
        }
        _number[number] = _randomNumber;
    }

    private void SpawnTaskProduct()
    {
        for (int i = 0; i < 2; i++)
        {
            RandomNumber(_scriptableObject.VegetablesSprites.VegetablesSprite.Count, i);
            _taskProdyct[i].sprite = _scriptableObject.VegetablesSprites.VegetablesSprite[_randomNumber];
        }
        for (int i = 2; i < 5; i++)
        {
            RandomNumber(_scriptableObject.ProductsSprites.ProductSpoiledSprite.Count, i);
            _taskProdyct[i].sprite = _scriptableObject.ProductsSprites.ProductSprite[_randomNumber];
        }
    }
}