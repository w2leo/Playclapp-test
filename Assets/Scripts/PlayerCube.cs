using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : MonoBehaviour
{
    private float startSpeed;
    private float maxDistance;
    private float currentDistance;

    private void Update()
    {
        if (currentDistance < maxDistance)
        {
            MoveCube();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void MoveCube()
    {
        transform.Translate(Vector3.forward * startSpeed);
        currentDistance += startSpeed * Time.deltaTime;
    }

    public void StartMove(float startSpeed, float maxDistance)
    {
        currentDistance = 0;
    }
}
