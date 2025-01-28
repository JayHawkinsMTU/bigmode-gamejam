using UnityEngine;
using FMODUnity;
using FMOD.Studio;

namespace BigModeGameJam
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager instance { get; private set; }

        private void Awake()
        {
            if (instance != null)
            {
            Debug.LogError("Found more than one Audio Manager in the scene.");
            }
            instance = this;
        }
        public EventInstance CreateEventInstance(EventReference eventReference)
        {
            EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
            return eventInstance;
        }
    }
}
