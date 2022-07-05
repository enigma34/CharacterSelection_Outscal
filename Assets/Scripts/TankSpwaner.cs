using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public List<Tank> tankList;
    public TankView tankView;

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
        TankControler tankControler = new TankControler(tankModel, tankView);
    }
}
