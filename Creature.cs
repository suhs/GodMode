// Creature.cs
using System;

// Base for all creatures - to be inherited by God(player), Human, dog, cat, etc.
public class Creature {

  /* identity variables */
  // identifier. Might get decapitated
  protected int ID { get; set; }
  protected string Name { get; set; }
  protected string Sex { get; set; }

  /* randomization variables */
  // prob. of getting unexpected events&results. Should be fixed
  protected float lifeVariable { get; set; }
  // prob. of getting 'lucky' aka changing the calculated results to be closer to it's goal
  protected float Luck { get; set; }


  // status variables
  // a set of one-worded emotions
  protected string[] Emotions  { get; set; }

  // TODO : add Journey
  // TODO : add Power

}
