using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    private Player player;
    public float playerHealth;
    public float playerLives;
    [SerializeField] private Text healthText;
    [SerializeField] private Text livesText;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        playerHealth = player.health;
    }
    public void UpdateHealth()
    {
        player.UpdateHealth(playerHealth);
        healthText.text = playerHealth.ToString("0");
    }
    public void Lives()
    {
        player = FindObjectOfType<Player>();
        playerLives = player.lives;
    }
    public void UpdateLives()
    {
        player.Lives(playerLives);
        healthText.text = playerLives.ToString("0");
    }
}