using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;
    public int goldValue = 10; // Or gagné pour avoir tué l'ennemi

    private void OnMouseDown() // Fonction appelée lorsqu'on clique sur l'ennemi
    {
        TakeDamage(Player.Instance.clickDamage);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Player.Instance.GainGold(goldValue);
        // Logique pour augmenter la difficulté ou passer au stage suivant ici
        Destroy(gameObject); // Détruit l'ennemi
    }
}