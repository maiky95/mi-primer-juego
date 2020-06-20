using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : Pickable
{
    public override void PickupAction()
    {
        GameController.Instance.HandlePickable(Constants.Pickable.Gem);
    }
}
