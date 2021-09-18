using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{

    public GameObject CubeBase;
    public AudioSource OtherBGM;
    AudioSource BGM;
    // Start is called before the first frame update
    void Start()
    {
        BGM = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CubeBase.GetComponent<MeshRenderer>().enabled == true && !OtherBGM.isPlaying && !BGM.isPlaying)
        {
            BGM.Play();
        }
        else if(CubeBase.GetComponent<MeshRenderer>().enabled == false)
        {
            BGM.Pause();
        }
    }
}
