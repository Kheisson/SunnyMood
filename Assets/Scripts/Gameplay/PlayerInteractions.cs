using DefaultNamespace;
using UnityEngine;

public class PlayerInteractions
{

    #region Public Methods

    public void TryInteracting(Collider2D col)
    {
        if(col.TryGetComponent(typeof(IInteractable), out var interactable))
        {
            ((IInteractable)interactable)?.Interact();
        }
    }

    #endregion
}
