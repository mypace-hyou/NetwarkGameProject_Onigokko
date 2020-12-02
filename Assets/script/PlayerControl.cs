using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl inctanc { get; private set; }
    public int MyNumber;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MyNumber);
        Gamemanager.instanc.Nember += 1;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
