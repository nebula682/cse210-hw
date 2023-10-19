using System.Runtime;

public class CheckListGoal : Goal
{
     private int _amountCompleted;
     private int _target;
     private  int _bonus;

     public  int GetAmountCompleted()
     {
          return _amountCompleted;
     }
     public void SetAmountCompleted(int amountCompleted)
     {
          _amountCompleted = amountCompleted;
     }
     public int GetTarget()
     {
          return _target;
     }
     public void SetTarget(int target)
     {
          _target = target;
     }
     public int GetBonus()
     {
          return _bonus;
     }
     public void SetBonus(int bonus)
     {
          _bonus = bonus;
     }
     
     
     
}