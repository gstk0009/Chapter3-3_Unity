using UnityEngine;

public class Monster : MonoBehaviour
{
    private MonsterSO monsterSO;
    private CreateMonster createMonster;
    private Rigidbody2D rigidbody2d;
    private float maxHp;
    private float hp;
    private string name;
    private float gold;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Attacked(float attackPower)
    {
        hp -= attackPower;
        GameManager.Instance.monsterHp.text = hp.ToString();
        UpdateSlider();
        if (hp <= 0)
        {
            GameManager.Instance.GetGold(gold);
            this.gameObject.SetActive(false);
            GameManager.Instance.stage += 1f;
            createMonster.SetMonster();
        }
    }

    public void SetMonsterSO(MonsterSO SO)
    {
        monsterSO = SO;

        hp = monsterSO.HP;
        maxHp = hp;
        name = monsterSO.name;
        gold = monsterSO.Gold;

        GameManager.Instance.monsterHp.text = hp.ToString();
        GameManager.Instance.monsterName.text = name;
    }

    public void SetCreateMonster(CreateMonster create)
    {
        createMonster = create;
    }

    public void UpdateSlider()
    {
        GameManager.Instance.slider.value = hp / maxHp;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attacked(collision.GetComponentInParent<Player>().attackPower);
    }
}
