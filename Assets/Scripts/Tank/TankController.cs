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


    public void TankMovement(float vertical, Rigidbody rb, Transform transform)
    {
        var pos = transform.forward * vertical * TankModel.Speed * Time.deltaTime;
        rb.MovePosition(rb.position + pos);

    }

    public void TankRotation(Vector3 _rotation, Transform transform1)
    {
        if (Input.GetKey(KeyCode.D))
            _rotation = Vector3.up;
        else if (Input.GetKey(KeyCode.A))
            _rotation = Vector3.down;
        else _rotation = Vector3.zero;

        transform1.Rotate(_rotation * TankModel.RotationSpeed * Time.deltaTime);
    }

}
