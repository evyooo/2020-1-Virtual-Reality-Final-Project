using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foundkit : MonoBehaviour
{
    public GameObject cube;
    public AudioSource audioSource;
    public AudioClip bgm;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgm; 
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnMouseDown()
    { 
    	
    	GlobalVariable.score += 1;
    	Destroy(cube);
        
        audioSource.Play();
        audioSource.loop = false; //반복 여부
    }

}
