using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class MainManagerProductSelectionStage : MonoBehaviour
{
    [SerializeField] private ProductTaskController _taskController;
    [SerializeField] private RackController _rackController;

    void Start()
    {
        GameInit();
    }

    private void GameInit()
    {
        _taskController.SpawnTaskProduct();
        _rackController.SpawnRackProduct();
    }
}