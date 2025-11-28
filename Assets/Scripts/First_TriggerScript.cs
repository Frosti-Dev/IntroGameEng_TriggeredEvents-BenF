using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class First_TriggerScript : MonoBehaviour
{
    public PlayableDirector director;

    private void OnTriggerEnter(Collider other)
    {
        director.Play();
    }


}
