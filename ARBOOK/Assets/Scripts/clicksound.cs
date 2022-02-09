using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Button))]
public class clicksound : MonoBehaviour
{
    public AudioClip sound;
    private Button button { get { return GetComponent<Button>();  } }
    private AudioSource src { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        src.clip = sound;
        src.playOnAwake = false;
        button.onClick.AddListener(() => PlaySound());
    }
    void PlaySound()
    {
        src.PlayOneShot(sound);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
