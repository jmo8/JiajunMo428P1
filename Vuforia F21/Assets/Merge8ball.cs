using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Merge8ball : MonoBehaviour
{

    public GameObject MergeEightball;
    public GameObject Mergecube;
    AudioSource Switch;

    string[] EightBall = new string[] {"It is Certain","It is decidedly so","Without a doubt","Yes definitely","You may rely on it","As I see it, yes.","Most likely","Outlook good","Yes","Signs point to yes","Reply hazy, try again","Ask again later","Better not tell you now","Cannot predict now","Concentrate and ask again","Don't count on it","My reply is no","My sources say no","Outlook not so good","Very doubtful"};

    int flip;
    int back;
    

    // Start is called before the first frame update
    void Start()
    {
        flip = 0;
        back = 0;
        MergeEightball.GetComponent<TextMeshPro>().text = EightBall[Random.Range(0, EightBall.Length - 1)];
        Switch = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Mergecube.GetComponent<Transform>().localEulerAngles.z);
        if (flip != 1 && Mergecube.GetComponent<Transform>().localEulerAngles.z < 180)
        {
            flip = 1;
            Debug.Log("flip = 1");
        }
        if(flip == 1 && Mergecube.GetComponent<Transform>().localEulerAngles.z > 350)
        {
            back = 1;
            Debug.Log("back = 1");
        }
        if(flip == 1 && back == 1)
        {
            flip = 0;
            back = 0;
            MergeEightball.GetComponent<TextMeshPro>().text = EightBall[Random.Range(0, EightBall.Length - 1)];
            Switch.Play();
            Debug.Log("reset");
        }
    }
}
