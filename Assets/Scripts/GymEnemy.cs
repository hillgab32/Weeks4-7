using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class GymEnemy : MonoBehaviour
{
    float health = 10;
    float hitBox = 1;
    public GameObject livingEnemy;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        float range = Vector3.Distance(worldMousePosition, transform.position);
        
        if (range < hitBox)
        {
            if(Mouse.current.leftButton.wasReleasedThisFrame)
            {
                health = health - 1;
            }
        }

        if (health <= 0) 
        {
            Destroy(livingEnemy);
        }
    }
}
