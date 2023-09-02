using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero : MonoBehaviour
{
  public HeroData heroData;
  private bool isAttacking;
  private List<GameObject> enemies;
  private CircleCollider2D rangeAttack;
  private SkeletonAnimation skeletonAnimation;

  private void Awake()
  {
    rangeAttack = GetComponent<CircleCollider2D>();
    skeletonAnimation = heroData.HeroSpineData.GetComponent<SkeletonAnimation>();
    skeletonAnimation.AnimationState.SetAnimation(0, "idle", true);
  }
  private void Update()
  {
    if (enemies.Count == 0) {
      isAttacking = false;
    }
  }
  private void FixedUpdate()
  {
    if (isAttacking)
    {
      skeletonAnimation.AnimationState.SetAnimation(0, "atk", true);
      Attack();
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    collision.gameObject.CompareTag("Enemy");
    enemies.Add(collision.gameObject);
    isAttacking = true;
  }

  public abstract void Attack();
}
