using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMonster : MonoBehaviour
{
    [SerializeField] MonsterSO monsterSO;
    [SerializeField] GameObject monsterPrefab;
    private GameObject obj;

    private void Start()
    {
        monsterSO.HP = 10;
        monsterSO.name = "monster0";
        monsterSO.Gold = 10;
        createMonster();
    }

    private void createMonster()
    {
        obj = Instantiate(monsterPrefab);
        obj.GetComponent<Monster>().SetMonsterSO(monsterSO);
        obj.GetComponent<Monster>().SetCreateMonster(this);
    }

    public void  SetMonster()
    {
        monsterSO.HP += GameManager.Instance.stage * 2;
        monsterSO.name = "monster" + (GameManager.Instance.stage).ToString();
        monsterSO.Gold += GameManager.Instance.stage * 2;
        obj.GetComponent<Monster>().SetMonsterSO(monsterSO);
        StartCoroutine(RespawnMonster());
    }

    IEnumerator RespawnMonster()
    {
        yield return new WaitForSeconds(1f);
        obj.SetActive(true);
    }
}
