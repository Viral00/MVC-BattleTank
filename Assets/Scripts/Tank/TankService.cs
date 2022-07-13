using System;
using UnityEngine;

public class TankService : MonoSingleton<TankService>
{
    public TankView tankprefab;
    
    public void Start()
    {
        TankModel tankModel = new TankModel(10f, 50f);
        TankController tank = new TankController(tankModel, tankprefab);
    }
}
