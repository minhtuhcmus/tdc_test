using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public enum EnemyType
  {
    E1,
    E2
  }
  public List<EnemyData> enemyDatas;
  public EnemyType type { get; private set; }
  public EnemyData enemyData { get; private set; }
  public Enemy(EnemyType enemyType)
  {
    enemyData = enemyDatas[(int)enemyType];
  }
}
