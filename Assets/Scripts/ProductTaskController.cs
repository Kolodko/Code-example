using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ProductTaskController : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> _taskProdyct = new List<SpriteRenderer>();

    //Спавн продуктов в списке задач
    public void SpawnTaskProduct()
    {
        for (int i = 0; i < 2; i++)
        {
            _taskProdyct[i].sprite = MixList.Instance.Scriptable.VegetablesSprites.VegetablesSprite[MixList.Instance.Scriptable.mixArray[i]];
            MixList.Instance.Scriptable.TaskList[i] = _taskProdyct[i].sprite;
            MixList.Instance.Scriptable.mixArray.RemoveAt(i);
        }
        for (int i = 2; i < 5; i++)
        {
            _taskProdyct[i].sprite = MixList.Instance.Scriptable.ProductsSprites.ProductSprite[MixList.Instance.Scriptable.mixArray[i]];
            MixList.Instance.Scriptable.TaskList[i] = _taskProdyct[i].sprite;
        }
    }
}