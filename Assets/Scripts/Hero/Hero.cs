using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero : MonoBehaviour
{
  public HeroData heroData;
  private bool enemyInRange = false;
  private List<GameObject> enemies;
  private CircleCollider2D rangeForAttack;
  private SkeletonAnimation skeletonAnimation;

  private void Awake()
  {
    enemies = new List<GameObject>();
    rangeForAttack = GetComponent<CircleCollider2D>();
    rangeForAttack.radius = heroData.Range*4;
    skeletonAnimation = GetComponent<SkeletonAnimation>();
    skeletonAnimation.AnimationState.SetAnimation(0, "idle", true);
  }
  private void Update()
  {
    if (enemies.Count > 0)
    {
      enemyInRange = true;
    } else
    {
      enemyInRange = false;
    }
  }
  private void FixedUpdate()
  {
    if (enemyInRange && enemies.Count > 0)
    {
      skeletonAnimation.AnimationState.SetAnimation(0, heroData.AttackType, true);
      Attack();
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    collision.gameObject.CompareTag("Enemy");
    enemies.Add(collision.gameObject);
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    enemies.Remove(collision.gameObject);
  }

  public abstract void Attack();
}
