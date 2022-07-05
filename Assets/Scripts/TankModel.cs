using UnityEngine;

public class TankModel
{
    TankControler tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float _movementSpeed, float _rotationSpeed)
    {
        movementSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;
    }

    public void SetTankController(TankControler _tankControler)
    {
        tankController = _tankControler;
    }
}
