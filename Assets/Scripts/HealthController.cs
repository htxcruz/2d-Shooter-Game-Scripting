using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    private Player player;
    public float playerHealth;
    [SerializeField] private Text healthText;

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
}