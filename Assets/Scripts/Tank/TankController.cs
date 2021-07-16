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


    public void TankMovement(float horizontal, float vertical, Rigidbody rb, Transform transform)
    {
        var pos = transform.forward * vertical * TankModel.Speed * Time.deltaTime;
        rb.MovePosition(rb.position + pos);

        /*Vector3 inputVector = new Vector3(horizontal * TankModel.Speed, rb.velocity.y, vertical * TankModel.Speed).normalized;
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0f, inputVector.z));
        rb.velocity = inputVector* Time.deltaTime;*/
    }

}
