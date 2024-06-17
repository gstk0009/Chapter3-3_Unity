using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float stage = 1;
    public float Gold = 0;
    public TextMeshProUGUI monsterHp;
    public TextMeshProUGUI monsterName;
    public TextMeshProUGUI PlayerGold;
    public Player player;
    public Slider slider;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }

    private void Start()
    {
        StartCoroutine(StartAutoClick());
    }

    IEnumerator StartAutoClick()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            player.anim.SetBool("OneTab", true);
            yield return new WaitForSeconds(0.5f);
            player.anim.SetBool("OneTab", false);
        }
    }

    public void GetGold(float monsterGold)
    {
        Gold += monsterGold;
        PlayerGold.text = Gold.ToString();
    }
}
