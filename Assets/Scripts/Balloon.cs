using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{
    public float speed;

    bool isMoving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {

        

        if (isMoving == true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
