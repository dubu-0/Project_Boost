using UnityEngine;

namespace Player
{
    public class PlayerSFX : MonoBehaviour
    {
        public void MuteEngine(bool mute)
        {
            PlayerComponentCollection.AudioSource.mute = mute;
        }
    }
}
