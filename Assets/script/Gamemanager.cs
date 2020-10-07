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

    ////確認
    //public Text luckText;
    //public Text luckText2;
    //public Text luckText3;

    ////テストプレイ用
    //public GameObject button_1;
    //public GameObject button_2;
    //public GameObject button_3;


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

    ////役職確認
    //public Text Position_1;
    //public Text Position_2;
    //public Text Position_3;
    //public Text Position_4;
    //public Text Position_5;
    //public Text Position_6;
    //public Text Position_7;
    //public Text Position_8;
    //public Text Position_9;
    //public Text Position_10;
    // Start is called before the first frame update
    void Start()
    {
        instanc = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSchedule == 0)//人が集まるかどうか
        {
            //luckText3.gameObject.SetActive(false);
            //luckText2.gameObject.SetActive(true);
            //button_3.SetActive(false);
            //button_1.SetActive(true);
            Schedulech_2 = false;
            //luckText.text = "人が集まった";
            if (Schedulech_0 == true)
            {
                GameSchedule += 1;
            }
        }
        if (GameSchedule == 1)//逃げる
        {
            //button_1.SetActive(false);
            //luckText.text = "逃げて";
            EscapeTime -= Time.deltaTime;
            //luckText2.text = EscapeTime.ToString("F1");
            if (EscapeTime <= 10)//役職発表
            {
                //luckText.text = "貴方の役職はです";
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
            //luckText2.gameObject.SetActive(false);
            //luckText3.gameObject.SetActive(true);
            //luckText.text = "プレイ中";
            PlayTime -= Time.deltaTime;
            //luckText3.text = PlayTime.ToString("F1");
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
            //button_2.SetActive(true);
            //luckText.text = "終了";
            if (Schedulech_1 == true)
            {
                ch_oni();
                GameSchedule += 1;
            }
        }
        if (GameSchedule == 4)//待機
        {
            SceneManager.LoadScene("sceneCheng");
            //button_2.SetActive(false);
            //button_3.SetActive(true);
            //luckText.text = "次のゲームまで待機";
            //Schedulech_0 = false;
            //Schedulech_1 = false;
            //EscapeTime = EscapeTimeIntarval;
            //PlayTime = PlayTimeIntarval;
            //if (Schedulech_2 == true)
            //{
            //    GameSchedule = 0;
            //}
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
            //Position_1.text = "鬼";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 2)
        {
            oni_2 = true;
            //Position_1.text = "人";
            //Position_2.text = "鬼";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 3)
        {
            oni_3 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "鬼";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 4)
        {
            oni_4 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "鬼";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 5)
        {
            oni_5 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "鬼";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 6)
        {
            oni_6 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "鬼";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 7)
        {
            oni_7 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "鬼";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 8)
        {
            oni_8 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "鬼";
            //Position_9.text = "人";
            //Position_10.text = "人";
        }
        if (oni_jb == 9)
        {
            oni_9 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "鬼";
            //Position_10.text = "人";
        }
        if (oni_jb == 10)
        {
            oni_10 = true;
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "鬼";
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
            //Position_1.text = "鬼";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "鬼";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "鬼";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "鬼";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "鬼";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "鬼";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "鬼";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "鬼";
            //Position_9.text = "人";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "鬼";
            //Position_10.text = "人";
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
            //Position_1.text = "人";
            //Position_2.text = "人";
            //Position_3.text = "人";
            //Position_4.text = "人";
            //Position_5.text = "人";
            //Position_6.text = "人";
            //Position_7.text = "人";
            //Position_8.text = "人";
            //Position_9.text = "人";
            //Position_10.text = "鬼";
        }
    }
}
