using System.Collections.Generic;
using System.Collections;
using DG.Tweening;
using UnityEngine;

public class ProductController : MonoBehaviour
{
    [SerializeField] private List<ButtonFood> _buttonFood = new List<ButtonFood>();

    //����������� ������ ������� �� �������� �� ������
    public void SetTaskProduct(int count)
    {
        Init();
        for (int i = 0; i < 4; i++)
        {
            _buttonFood[i].GetComponent<SpriteRenderer>().sprite = MixList.Instance.Scriptable.TaskList[count];
            _buttonFood[i].TaskFood = true;
        }
    }

    //����������� ������ ������� �� ������� ��������
    public void SetDefaultProduct(int count)
    {
        int random = MixList.Instance.Scriptable.mixArray[count];
        for (int i = 0; i < 4; i++)
        {
            _buttonFood[i].GetComponent<SpriteRenderer>().sprite = MixList.Instance.Scriptable.VegetablesSprites.VegetablesSprite[random];
        }
    }

    //������ ������
    public void Init()
    {
        for (int i = 0; i < _buttonFood.Count; i++)
        {
            ButtonFood foodButton = _buttonFood[i];
            foodButton.Init(true, () => Product(foodButton));
        }
    }

    private void Product(ButtonFood buttons)
    {
        Debug.Log("clickProduct");
    }
}