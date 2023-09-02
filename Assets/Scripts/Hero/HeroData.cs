using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hero", menuName = "HeroData")]
public class HeroData : ScriptableObject
{
  public GameObject HeroSpineData;
  public int Range;
  public float Speed;
  public int Damage;
}
