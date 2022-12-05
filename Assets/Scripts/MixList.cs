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

    //������� ��������� ����� ��� ������ ������ � ���������
    public void Mix()
    {
        Scriptable.mixArray = Mix(Scriptable.numbers);
    }

    //������� ��������� ����� ��� ����� �� ������
    public void MixRack()
    {
        Scriptable.mixRackArray = Mix(Scriptable.Racknumbers);
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

    //��������������� ���������� ������ ����� ������ �� ����
    private void OnApplicationQuit()
    {
        for (int j = 0; j < Scriptable.numbers.Count; j++)
        { Scriptable.numbers.RemoveAt(j); }
        for (int i = 0; i < 15; i++)
        {
            if (Scriptable.numbers.Count < 15)
                Scriptable.numbers.Add(i);
            Scriptable.numbers[i] = i;
        }
    }
}
