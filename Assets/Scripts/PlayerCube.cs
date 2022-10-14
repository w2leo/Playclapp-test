using System;
using UnityEngine;

public class PlayerCube : MonoBehaviour
{
    private float startSpeed;
    private float maxDistance;
    private float currentDistance;
    private Vector3 startPosition;

    public void StartMoveCube(float startSpeed, float maxDistance)
    {
        startPosition = transform.position;
        currentDistance = 0;
        this.startSpeed = startSpeed;
        this.maxDistance = maxDistance;
    }

    private void Update()
    {
        if (currentDistance < maxDistance)
        {
            MoveCube();
        }
        else
        {
            EndMoveCube();
        }
    }

    private void EndMoveCube()
    {
        Debug.Log($"Cube '{gameObject.name}' passed distance = {Vector3.Distance(transform.position, startPosition)}");
        Destroy(gameObject);
    }

    private void MoveCube()
    {
        Vector3 oldPosition = transform.position;
        transform.Translate(Vector3.forward * startSpeed * Time.deltaTime);
        currentDistance += Vector3.Distance(oldPosition, transform.position);
    }
}
