using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public Vector3 spawnPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Spawn a runner!
            Instantiate(runnerPrefab);

            //Spawn a child of the runner object
            Instantiate(runnerPrefab, transform);

            //Spawn a runner at a specific position
            Instantiate(runnerPrefab, spawnPosition, Quaternion.identity);

            //Position of Zero:
            Vector3 zeroVector = Vector3.zero;

            //Rotation of Zero:
            Quaternion zeroRotation = Quaternion.identity;
        }
    }
}
