using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
  public enum HeroType
  {
    H1,
    H2
  }
  public List<HeroData> heroDatas;
  public HeroType type { get; private set; }
  public HeroData heroData { get; private set; }
  public Hero(HeroType heroType)
  {
    heroData = heroDatas[(int)heroType];
  }
}
