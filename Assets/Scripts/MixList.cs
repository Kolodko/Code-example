using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixList : MonoBehaviour
{
    public ScriptableObjectProduct Scriptable;
    public static MixList Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            Mix();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //Миксуем случайные цифры для спавна овощей и продуктов
    public void Mix()
    {
        Scriptable.MixList = Mix(Scriptable.Numbers);
    }

    //Миксуем случайные цифры для точек на полках
    public void MixRack()
    {
        Scriptable.MixRackList = Mix(Scriptable.Racknumbers);
    }

    List<int> Mix(List<int> num)
    {
        for (int i = 0; i < num.Count; i++)
        {
            int currentValue = num[i];
            int randomIndex = Random.Range(i, num.Count);
            num[i] = num[randomIndex];
            num[randomIndex] = currentValue;
        }
        return num;
    }

    //Восстанавливаем скриптейбл список после выхода из игры
    private void OnApplicationQuit()
    {
        for (int j = 0; j < Scriptable.Numbers.Count; j++)
        { Scriptable.Numbers.RemoveAt(j); }
        for (int i = 0; i < 15; i++)
        {
            if (Scriptable.Numbers.Count < 15)
                Scriptable.Numbers.Add(i);
            Scriptable.Numbers[i] = i;
        }
    }
}
