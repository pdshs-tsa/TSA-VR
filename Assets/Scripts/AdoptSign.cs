using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class AdoptSign : MonoBehaviour
{
    public TMP_Text text;
    public AudioSource source;
    private readonly string words = "Your adoption request has been received.";
    
    // Start is called before the first frame update
    void Start()
    {
        text.SetText("");
    }

    public async void show()
    {
        playSound();
        text.text = words;
        await Task.Delay(3500);
        text.text = "";
    }

    private void playSound()
    {
        source.Play();
    }
}
