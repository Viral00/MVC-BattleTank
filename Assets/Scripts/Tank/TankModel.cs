using UnityEngine;

public class TankModel
{
    public TankModel(float speed, float _rotationSpeed)
    {
        Speed = speed;
        RotationSpeed = _rotationSpeed;
    }
    public float Speed { get; }
    public float RotationSpeed { get; }
}
    
