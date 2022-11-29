using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class RackController : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] private ProductController _productController;

    private void SpawnRackProduct()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            ProductController clone = Instantiate(_productController, _spawnPoints[i].position, _spawnPoints[i].rotation);
            clone.transform.parent = _spawnPoints[i].transform;
        }
    }
}