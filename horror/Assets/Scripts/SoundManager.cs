using UnityEngine;

namespace greta
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            instance = this;
            
            aud = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip sound, Vector2 rangeVolume) 
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }
    }
}

