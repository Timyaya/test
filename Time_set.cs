using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Time_set : MonoBehaviour
{
    public Text gametime;
    private float starttime;
    private bool doned = false;

    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(doned)
            return;

        float t = Time.time - starttime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        gametime.text = "¹CÀ¸®É¶¡: " + minutes + ":" + seconds;
    }

    public void Done()
    {
        doned = true;
        gametime.color = Color.yellow;

    }


}
