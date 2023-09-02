using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
  public EnemyData enemyData;
  private int health;
  private SkeletonAnimation skeletonAnimation;

  private void Awake()
  {
    health = enemyData.Health;
    skeletonAnimation = enemyData.EnemySpineData.GetComponent<SkeletonAnimation>();
    skeletonAnimation.AnimationState.SetAnimation(0, "Move_11", true);
  }
  private void Update()
  {
    Move();
  }
  private void FixedUpdate()
  {
    if (health <= 0)
    {
      Destroy(transform.gameObject);
    }
  }
  public void ReceivedDamage(int damage)
  {
    health -= damage;
  }
  public abstract void Move();
}
