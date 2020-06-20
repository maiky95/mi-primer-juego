using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : Pickable
{
    public override void PickupAction()
    {
        GameController.Instance.HandlePickable(Constants.Pickable.Cherry);
    }
}
