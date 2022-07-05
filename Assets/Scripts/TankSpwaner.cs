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
        //CreateTank();
    }

    public void CreateTank(TankTypes tankType)
    {
        TankModel tankModel;
        TankControler tankControler;
        switch (tankType)
        {
            case TankTypes.GreenTank:
                tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
                tankControler = new TankControler(tankModel, tankView);
                break;
            case TankTypes.BlueTank:
                tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
                tankControler = new TankControler(tankModel, tankView);
                break;
            case TankTypes.RedTank:
                tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
                tankControler = new TankControler(tankModel, tankView);
                break;
        }        
    }
}
