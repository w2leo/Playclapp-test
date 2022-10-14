using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private PlayerCube cubePrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private UserInput inputTime;
    [SerializeField] private UserInput inputSpeed;
    [SerializeField] private UserInput inputDistance;

    private float createTimeInSec;
    private float currentDelayInSec;

    private void InitTimer()
    {
        currentDelayInSec = 0;
    }

    private void Update()
    {
        currentDelayInSec += Time.deltaTime;
        createTimeInSec = inputTime.GetFloatValue();

        if (currentDelayInSec > createTimeInSec && createTimeInSec > 0)
        {
            SpawnCube(); 
            InitTimer();
        }
    }

    private void SpawnCube()
    {
        PlayerCube newCube = Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation);
        newCube.StartMoveCube(inputSpeed.GetFloatValue(), inputDistance.GetFloatValue());      
    }
}
