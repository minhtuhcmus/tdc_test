using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
  public override void Move()
  {
    if (Vector3.Distance(transform.position, this.target) < 0.1f)
    {
      Destroy(transform.gameObject);
    }
    Vector3 dir = target - transform.position;
    transform.position = transform.position + dir * Time.deltaTime * this.enemyData.Speed;

  }
}
