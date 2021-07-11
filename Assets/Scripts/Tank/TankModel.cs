using UnityEngine;

public class TankModel
{
    public TankModel(float speed, float turnSmoothtime)
    {
        Speed = speed;
        TurnSmoothtime = turnSmoothtime;
    }

    public float Speed { get; }
    public float TurnSmoothtime { get; }
}
    
