using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Mirror;

public class Unit : NetworkBehaviour
{
    [SerializeField] private UnitMovement unitMovement = null;
    [SerializeField] private UnityEvent onSelected = null;
    [SerializeField] private UnityEvent onDeSelected = null;

    public UnitMovement GetUnitMovement()
    {
        return unitMovement;
    }

    #region Client
    [Client]
    public void Select()
    {
        if(!hasAuthority) { return; }

        onSelected?.Invoke();
    }

    [Client]
    public void deSelect()
    {
        if (!hasAuthority) { return; }

        onDeSelected?.Invoke();
    }

    #endregion
}
