using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI LvCount;
    public TextMeshProUGUI DamageCount;
    public TextMeshProUGUI LvUpDamage;
    public TextMeshProUGUI LvUpGold;
    private Player player;
    private int lvCount = 1;
    private float lvDamage = 1f;
    private int lvUpGold = 1;
    private float lvUpDamage = 1;

    private void Start()
    {
        player = GameManager.Instance.player;

        LvCount.text = lvCount.ToString();
        DamageCount.text = lvDamage.ToString();
        LvUpDamage.text = lvUpDamage.ToString();
        LvUpGold.text = lvUpGold.ToString();
    }

    public void LvUp()
    {
        if (GameManager.Instance.Gold > lvUpGold)
        {
            GameManager.Instance.LvUpGold(lvUpGold);
            lvCount++;
            lvUpGold *= 2;
            lvUpDamage += 1f;
            lvDamage = lvUpDamage;

            LvCount.text = lvCount.ToString();
            DamageCount.text = lvDamage.ToString();
            LvUpDamage.text = lvUpDamage.ToString();
            LvUpGold.text = lvUpGold.ToString();

            player.attackPower = lvDamage;
        }
    }
}
