using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private PlayerCube cubePrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private InputField inputTime;
    [SerializeField] private InputField inputSpeed;
    [SerializeField] private InputField inputDistance;

    private float createTime;
    private float startSpeed;
    private float maxDistance;

    private float currentDelay;

    private void Update()
    {
        currentDelay += Time.deltaTime;
        SetValues();
        if (currentDelay > createTime && createTime != 0)
        {
            SpawnCube();
        }
    }

    private void SetValues()
    {
        createTime = float.Parse(inputTime.text);
        startSpeed = float.Parse(inputSpeed.text);
        maxDistance = float.Parse(inputDistance.text);
    }

    private void SpawnCube()
    {
        PlayerCube newCube = Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation);
        newCube.StartMove(startSpeed, maxDistance);
        currentDelay = 0;
    }




}
