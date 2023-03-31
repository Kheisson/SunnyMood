using UnityEngine;

namespace DefaultNamespace
{
    public class AudioManager : MonoBehaviour
    {
        #region Inspector

        [SerializeField] private AudioSource SfxSource;

        #endregion

        #region Public Sfx Enum

        public enum Sfx
        {
            Gem,
            Jump,
        }

        #endregion
        
        #region Public Properties
        public static AudioManager Instance { get; private set; }

        #endregion

        #region Fields

        private AudioClip _gemPickupSfx;
        private AudioClip _jumpSfx;

        #endregion

        #region Private Methods

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                _gemPickupSfx ??= Resources.Load<AudioClip>("Audio/PickGem");
                _jumpSfx ??= Resources.Load<AudioClip>("Audio/Jump");
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        #endregion

        #region Public Methods

        public void PlaySfx(Sfx sfx)
        {
            switch (sfx)
            {
                case Sfx.Gem:
                    SfxSource.PlayOneShot(_gemPickupSfx);
                    break;
                case Sfx.Jump:
                    SfxSource.PlayOneShot(_jumpSfx);
                    break;
            }
        }

        #endregion
    }
}