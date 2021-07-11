using UnityEngine;

public class TankService : MonoSingleton<TankService>
{
    public TankView tankprefab;

    
    public void Start()
    {
        TankModel tankModel = new TankModel(0.01f, 0.01f);
        TankController tank = new TankController(tankModel, tankprefab);
    }
}
