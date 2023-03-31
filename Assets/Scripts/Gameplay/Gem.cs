using UnityEngine;

namespace DefaultNamespace
{
    public class Gem : MonoBehaviour, IInteractable
    {
        #region Public Methods

        public void Interact()
        {
            if(AudioManager.Instance != null)
                AudioManager.Instance.PlaySfx(AudioManager.Sfx.Gem);

            Destroy(gameObject);
        }

        #endregion
    }
}