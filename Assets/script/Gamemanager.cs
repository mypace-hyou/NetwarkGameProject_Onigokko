using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instanc { get; private set; }
    public float number;

    //大まかな流れを管理
    public float GameSchedule;
    public float Nember;

    //各自判定
    public bool Schedulech_0 = false;
    public bool Schedulech_1 = false;
    public bool Schedulech_2 = false;

    public bool jb = true;

    //時間管理
    public float EscapeTime = 30;
    public float PlayTime = 40;

    //インターバル
    public float EscapeTimeIntarval = 30;
    public float PlayTimeIntarval = 40;

    //鬼を決める
    public float oni_jb;
    public float onijb_ch;

    public static int DemonPlayer;

    //鬼かどうかの判定
    public bool oni_1 = false;
    public bool oni_2 = false;
    public bool oni_3 = false;
    public bool oni_4 = false;
    public bool oni_5 = false;
    public bool oni_6 = false;
    public bool oni_7 = false;
    public bool oni_8 = false;
    public bool oni_9 = false;
    public bool oni_10 = false;

    //入った判定
    public bool Login_1 = false;
    public bool Login_2 = false;
    public bool Login_3 = false;
    public bool Login_4 = false;
    public bool Login_5 = false;
    public bool Login_6 = false;
    public bool Login_7 = false;
    public bool Login_8 = false;
    public bool Login_9 = false;
    public bool Login_10 = false;
    // Start is called before the first frame update
    void Start()
    {
        instanc = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Nember == 10)
        {
            onbotton_1();
        }
        if (GameSchedule == 0)//人が集まるかどうか
        {
            Schedulech_2 = false;
            if (Schedulech_0 == true)
            {
                GameSchedule += 1;
            }
        }
        if (GameSchedule == 1)//逃げる
        {
            EscapeTime -= Time.deltaTime;
            if (EscapeTime <= 10)//役職発表
            {
                first_Oni();
            }
            if (EscapeTime <= 0)
            {
                GameSchedule += 1;
            }
        }
        if (GameSchedule == 2)//プレイ
        {
            Cheng_Oni();
            PlayTime -= Time.deltaTime;
            if (PlayTime <= 30)
            {
                //luckText3.text = "残り時間少し";
            }
            if (PlayTime <= 0)
            {
                GameSchedule += 1;
            }
        }
        if (GameSchedule == 3)//終了
        {
            if (Schedulech_1 == true)
            {
                ch_oni();
                GameSchedule += 1;
            }
        }
        if (GameSchedule == 4)//待機
        {
            SceneManager.LoadScene("sceneCheng");
        }
    }
    public void onbotton_1()
    {
        Schedulech_0 = true;
    }
    public void onbotton_2()
    {
        Schedulech_1 = true;
    }
    public void onbotton_3()
    {
        Schedulech_2 = true;
    }
    public void first_Oni()
    {
        oni_jb = Random.Range(1, 11);
        if (oni_jb == 1)
        {
            oni_1 = true;
        }
        if (oni_jb == 2)
        {
            oni_2 = true;
        }
        if (oni_jb == 3)
        {
            oni_3 = true;
        }
        if (oni_jb == 4)
        {
            oni_4 = true;
        }
        if (oni_jb == 5)
        {
            oni_5 = true;
        }
        if (oni_jb == 6)
        {
            oni_6 = true;
        }
        if (oni_jb == 7)
        {
            oni_7 = true;
        }
        if (oni_jb == 8)
        {
            oni_8 = true;
        }
        if (oni_jb == 9)
        {
            oni_9 = true;
        }
        if (oni_jb == 10)
        {
            oni_10 = true;
        }
    }
    public void ch_Titol()
    {
        SceneManager.LoadScene("TitolScene");
    }
    public void ch_Result()
    {
        SceneManager.LoadScene("Result");
    }
    public void ch_play()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void ch_oni()//消す
    {
        if (onijb_ch == 1)
        {
            DemonPlayer = 1;
        }
        if (onijb_ch == 2)
        {
            DemonPlayer = 2;
        }
        if (onijb_ch == 3)
        {
            DemonPlayer = 3;
        }
        if (onijb_ch == 4)
        {
            DemonPlayer = 4;
        }
        if (onijb_ch == 5)
        {
            DemonPlayer = 5;
        }
        if (onijb_ch == 6)
        {
            DemonPlayer = 6;
        }
        if (onijb_ch == 7)
        {
            DemonPlayer = 7;
        }
        if (onijb_ch == 8)
        {
            DemonPlayer = 8;
        }
        if (onijb_ch == 9)
        {
            DemonPlayer = 9;
        }
        if (onijb_ch == 10)
        {
            DemonPlayer = 10;
        }
    }
    public void Cheng_Oni()
    {
        onijb_ch = Random.Range(1, 11);
        if (onijb_ch == 1)
        {
            oni_1 = true;
            oni_2 = false;
            oni_3 = false;
            oni_4 = false;
            oni_5 = false;
            oni_6 = false;
            oni_7 = false;
            oni_8 = false;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 2)
        {
            oni_1 = false;
            oni_2 = true;
            oni_3 = false;
            oni_4 = false;
            oni_5 = false;
            oni_6 = false;
            oni_7 = false;
            oni_8 = false;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 3)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = true;
            oni_4 = false;
            oni_5 = false;
            oni_6 = false;
            oni_7 = false;
            oni_8 = false;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 4)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = false;
            oni_4 = true;
            oni_5 = false;
            oni_6 = false;
            oni_7 = false;
            oni_8 = false;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 5)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = false;
            oni_4 = false;
            oni_5 = true;
            oni_6 = false;
            oni_7 = false;
            oni_8 = false;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 6)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = false;
            oni_4 = false;
            oni_5 = false;
            oni_6 = true;
            oni_7 = false;
            oni_8 = false;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 7)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = false;
            oni_4 = false;
            oni_5 = false;
            oni_6 = false;
            oni_7 = true;
            oni_8 = false;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 8)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = false;
            oni_4 = false;
            oni_5 = false;
            oni_6 = false;
            oni_7 = false;
            oni_8 = true;
            oni_9 = false;
            oni_10 = false;
        }
        if (onijb_ch == 9)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = false;
            oni_4 = false;
            oni_5 = false;
            oni_6 = false;
            oni_7 = false;
            oni_8 = false;
            oni_9 = true;
            oni_10 = false;
        }
        if (onijb_ch == 10)
        {
            oni_1 = false;
            oni_2 = false;
            oni_3 = false;
            oni_4 = false;
            oni_5 = false;
            oni_6 = false;
            oni_7 = false;
            oni_8 = false;
            oni_9 = false;
            oni_10 = true;
        }
    }
}
