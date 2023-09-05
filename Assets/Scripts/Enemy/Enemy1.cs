using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
  private List<Vector3> targets;
  private int currentTargetIndex = 0;

  private void Awake()
  {
    this.target = targets[currentTargetIndex];
  }
  public override void Move()
  {
    if (Vector3.Distance(transform.position, this.target) < 0.1f)
    {
      FindNextTarget();
    }
    Vector3 dir = target - transform.position;
    transform.position = transform.position + dir * Time.deltaTime * this.enemyData.Speed;
  }

  void FindNextTarget()
  {
    currentTargetIndex++;
    if (currentTargetIndex < targets.Count - 1)
    {
      this.target = targets[currentTargetIndex];
    } else
    {
      Destroy(transform.gameObject);
    }
  }
}
