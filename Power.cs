// Power.cs
using UnityEngine;
using System;

// power variables
public class Power : MonoBehaviour {
  // prob. of overall power. Higher this value, more chance your action overriding result
  protected float willPower { get; set; }

  // prob. of performing each action. These three SHOULD SUM UP TO 1
  //
  protected float constructionPower { get; set; }
  protected float destructionPower { get; set; }
  protected float observationPower { get; set; }


}
