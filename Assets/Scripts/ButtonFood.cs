using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;

public class ButtonFood : MonoBehaviour
{
    public ColliderButton Button => _button;
    public ColliderButton _button;

    public bool TaskFood;
    public bool DefaultFood;

    public void Init(bool active, Action onClick)
    {
        _button.OnClick.RemoveAllListeners();
        _button.OnClick.AddListener(() => onClick?.Invoke());
    }

    public void SetCollider(bool enabled)
    {
        _button.enabled = enabled;
    }

    public void TaskFoodAnimation()
    {

    }

    public void DefaultFoodAnimation()
    {

    }
}