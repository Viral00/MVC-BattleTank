using UnityEngine;

public class TankView: MonoBehaviour
{
    public CharacterController Controller;
    public Transform Cam;
    public TankController tankcontroller;
    private float turnSmoothVelocity;

    public TankView(TankController tankController)
    {
        TankController = tankController;
    }
    public TankController TankController { get; }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal1");
        float vertical = Input.GetAxisRaw("Vertical1");

        tankcontroller.TankMovement(horizontal, vertical, Cam, transform, turnSmoothVelocity, Controller);
        
    }
}
