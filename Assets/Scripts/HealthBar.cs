using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class HealthBar : MonoBehaviour
{
    public Image healthBarFillImage;
    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public SpriteRenderer enemyRenderer;
    public AudioSource damageSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        worldMousePosition.z = 0;

        bool isMouseClicked = Mouse.current.leftButton.wasReleasedThisFrame;
        bool isMouseOverEnemy = enemyRenderer.bounds.Contains(worldMousePosition);

        bool shouldTakeDamage = isMouseOverEnemy && isMouseClicked;
        Debug.Log("Click["+ isMouseClicked + "] OverEnemy[" + isMouseOverEnemy + "]");
        if(shouldTakeDamage)
        {
            damageSound.Play();
            currentHealth -= 5f;
            if (currentHealth <= 0)
            {
                enemyRenderer.gameObject.SetActive(false);
            }
            healthBarFillImage.fillAmount = currentHealth / maxHealth;
        }

        
    }
}
