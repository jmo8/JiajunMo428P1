using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Class8ball : MonoBehaviour
{

    public GameObject ClassEightball;
    public GameObject Classcube;
    AudioSource Switch;

    string[] EightBall = new string[] { "Sounds good", "The TRUE","Maybe think again", "Unparalleled affirmation", "Doesn't sound great","The FALSE","Should pause and rethink","Next time i tell you", "Dangerous Feeling", "Don't think too much, let nature take its course", "Surely next time" };

    int flip;
    int back;


    // Start is called before the first frame update
    void Start()
    {
        flip = 0;
        back = 0;
        ClassEightball.GetComponent<TextMeshPro>().text = EightBall[Random.Range(0, EightBall.Length - 1)];
        Switch = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(Mathf.Abs(Classcube.GetComponent<Transform>().localRotation.z));
        if (flip != 1 && Mathf.Abs(Classcube.GetComponent<Transform>().localRotation.z) >= 0.9f)
        {
            flip = 1;
            Debug.Log("flip = 1");
        }
   
        if (flip == 1 && back != 1 && Mathf.Abs(Classcube.GetComponent<Transform>().localRotation.z) <= 0.01f)
        {
            back = 1;
            Debug.Log("back = 1");
        }

        if (flip == 1 && back == 1)
        {
            flip = 0;
            back = 0;
            ClassEightball.GetComponent<TextMeshPro>().text = EightBall[Random.Range(0, EightBall.Length - 1)];
            Switch.Play();
            Debug.Log("reset");
        }
    }

    
}
