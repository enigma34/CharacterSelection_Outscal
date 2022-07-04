using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public TankView tankView;

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    void CreateTank()
    {
        TankModel tankModel = new TankModel();
        TankControler tankControler = new TankControler(tankModel, tankView);
    }
}
