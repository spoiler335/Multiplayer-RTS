using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Mirror;

public class Unit : NetworkBehaviour
{
    [SerializeField] private UnityEvent onSelected = null;
    [SerializeField] private UnityEvent onDeSelected = null;

    #region Client
    public void Select()
    {
        if(!hasAuthority) { return; }

        onSelected?.Invoke();
    }

    public void deSelect()
    {
        if (!hasAuthority) { return; }

        onDeSelected?.Invoke();
    }

    #endregion
}
