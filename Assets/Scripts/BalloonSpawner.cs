using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject balloonPrefab;
    public GameObject existingBalloon;
    public Vector3 spawnPosition;
    public float spawnSpeed;
    public Slider sliderPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSpawnPress()
    {

        Vector2 handlePosition = Camera.main.ScreenToWorldPoint(sliderPosition.handleRect.position);

        
        



        GameObject spawnedObject = Instantiate(balloonPrefab, handlePosition, Quaternion.identity);

        spawnedObject.GetComponent<Balloon>().speed = spawnSpeed;

        SpriteRenderer spawnedSpriteRenderer = spawnedObject.GetComponent<SpriteRenderer>();
        if (spawnedSpriteRenderer != null)
        {
            spawnedSpriteRenderer.color = Color.red;
            
        }


        //MAKE THE SPAWNED OBJECT MOVE AT SPAWNSPEED:
        Balloon spawnedBalloon = spawnedObject.GetComponent<Balloon>();

        if (spawnedBalloon != null)
        {
            spawnedBalloon.speed = spawnSpeed;
        }


        Destroy(spawnedObject, 6f);
    }
}

