using UnityEngine;

public class WaterHazard : MonoBehaviour
{
    public float speed;

    bool isRising = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isRising)
        {
            transform.localScale += Vector3.up * speed * Time.deltaTime;
        }
    }

    public void WaterRising()
    {
        isRising = true;
    }


}
