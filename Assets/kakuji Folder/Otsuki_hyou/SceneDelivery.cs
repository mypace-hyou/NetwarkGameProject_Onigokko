using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDelivery : MonoBehaviour
{
    public static float demonPlayer;

    public bool demonPlayer_1;
    public bool demonPlayer_2;
    public bool demonPlayer_3;
    public bool demonPlayer_4;
    public bool demonPlayer_5;
    public bool demonPlayer_6;
    public bool demonPlayer_7;
    public bool demonPlayer_8;
    public bool demonPlayer_9;
    public bool demonPlayer_10;
    // Start is called before the first frame update
    void Start()
    {
        demonPlayer = Gamemanager.DemonPlayer;

        if (demonPlayer == 1)
        {
            demonPlayer_1 = true;
            Debug.Log("1は鬼");
        }
        if (demonPlayer == 2)
        {
            demonPlayer_2 = true;
            Debug.Log("2は鬼");
        }
        if (demonPlayer == 3)
        {
            demonPlayer_3 = true;
            Debug.Log("3は鬼");
        }
        if (demonPlayer == 4)
        {
            demonPlayer_4 = true;
            Debug.Log("4は鬼");
        }
        if (demonPlayer == 5)
        {
            demonPlayer_5 = true;
            Debug.Log("5は鬼");
        }
        if (demonPlayer == 6)
        {
            demonPlayer_6 = true;
            Debug.Log("6は鬼");
        }
        if (demonPlayer == 7)
        {
            demonPlayer_7 = true;
            Debug.Log("7は鬼");
        }
        if (demonPlayer == 8)
        {
            demonPlayer_8 = true;
            Debug.Log("8は鬼");
        }
        if (demonPlayer == 9)
        {
            demonPlayer_9 = true;
            Debug.Log("9は鬼");
        }
        if (demonPlayer == 10)
        {
            demonPlayer_10 = true;
            Debug.Log("10は鬼");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
