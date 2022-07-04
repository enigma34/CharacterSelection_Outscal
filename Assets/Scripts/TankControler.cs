using UnityEngine;

public class TankControler 
{
    TankModel tankModel;
    TankView tankView;

    public TankControler(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = _tankView;
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}
