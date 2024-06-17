using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterSO", menuName = "Monster/Info")]
public class MonsterSO : ScriptableObject
{
    [Header("MonsterInfo")]
    public string Name;
    public float HP;
    public float Gold;
}
