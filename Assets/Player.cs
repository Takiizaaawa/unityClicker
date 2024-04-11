using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    public float clickDamage = 10f;
    public int gold = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GainGold(int amount)
    {
        gold += amount;
        // Mettre à jour l'UI ici
    }

    // Fonction pour dépenser de l'or et améliorer les dégâts, par exemple
    public void UpgradeClickDamage()
    {
        int upgradeCost = 100; // Coût fictif
        if (gold >= upgradeCost)
        {
            gold -= upgradeCost;
            clickDamage += 5; // Augmente les dégâts par clic
            // Mettre à jour l'UI ici
        }
    }
}

