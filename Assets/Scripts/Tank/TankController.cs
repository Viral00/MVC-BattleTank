using UnityEngine;

public class TankController
{
    public TankController(TankModel tankModel, TankView tankPrefab)
    {
        TankModel = tankModel;
        TankView = tankPrefab;
        TankView.tankcontroller = this;

    }

    public TankModel TankModel { get; }
    public TankView TankView { get; }


    public void TankMovement(float horizontal, float vertical, Transform cam, Transform transform, float turnSmoothVelocity, CharacterController controller)
    {

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.001f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, TankModel.TurnSmoothtime);

            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * TankModel.Speed * Time.deltaTime);

        }
    }
    
}
