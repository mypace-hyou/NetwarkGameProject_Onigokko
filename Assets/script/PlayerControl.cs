using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl inctanc { get; private set; }
    public float MyNumber;
    // Start is called before the first frame update
    void Start()
    {
        MyNumber = PhotonNetwork.LocalPlayer.ActorNumber;
        Debug.Log(MyNumber);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
