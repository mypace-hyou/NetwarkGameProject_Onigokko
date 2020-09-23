using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TouchAnim : MonoBehaviour
{
    PhotonView m_photonView;
    private Animator anim;
    private void Start()
    {
        m_photonView = GetComponent<PhotonView>();
    }
    void Update()
    {
        if (m_photonView.IsMine) 
        {
            Anim();
        } 
    }

    private void Anim() 
    {
        //左クリックを受け付ける
        if (Input.GetMouseButtonDown(0))
        {
            anim = this.gameObject.GetComponent<Animator>();
            anim.SetTrigger("Touch");
            Debug.Log("Left Click.");
        }
    }
}
