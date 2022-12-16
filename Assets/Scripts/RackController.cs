using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class RackController : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] private ProductController _productController;

    //Спавн продуктов на полках из списка задач и обычных продуктов
    public void SpawnRackProduct()
    {
        MixList.Instance.Mix();
        MixList.Instance.MixRack();
        for (int i = 0; i < 2; i++)
        {
            int number = MixList.Instance.Scriptable.MixRackList[i];
            ProductController clone = Instantiate(_productController, _spawnPoints[number].position, _spawnPoints[number].rotation);
            clone.transform.parent = _spawnPoints[number].transform;
            clone.SetTaskProduct(i);
            _spawnPoints.RemoveAt(number);
        }
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            ProductController clone = Instantiate(_productController, _spawnPoints[i].position, _spawnPoints[i].rotation);
            clone.transform.parent = _spawnPoints[i].transform;
            clone.SetDefaultProduct(i);
        }
    }
}