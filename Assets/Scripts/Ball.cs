using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static int LVLnum;
    public GameObject Panel;
    public GameObject secretpos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bin")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 2)
            {
                LVLnum = 2;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin2")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 3)
            {
                LVLnum = 3;
            }
                PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin3")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 4)
            {
                LVLnum = 4;
            }
                PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin4")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 5)
            {
                LVLnum = 5;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin5")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 6)
            {
                LVLnum = 6;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin6")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 7)
            {
                LVLnum = 7;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin7")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 9)
            {
                LVLnum = 9;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin9")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 10)
            {
                LVLnum = 10;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin10")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 11)
            {
                LVLnum = 11;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin11")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 12)
            {
                LVLnum = 12;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin12")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 13)
            {
                LVLnum = 13;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin13")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 14)
            {
                LVLnum = 14;
            }
                PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin14")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 15)
            {
                LVLnum = 15;
            }

            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin15")
        {
            if (LVLnum <= 16)
            {
                LVLnum = 16;
            }
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin16")
        {
            if (LVLnum <= 17)
            {
                LVLnum = 17;
            }
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin17")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 18)
            {
                LVLnum = 18;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin18")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 19)
            {
                LVLnum = 19;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin19")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 20)
            {
                LVLnum = 20;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin20")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 21)
            {
                LVLnum = 21;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin21")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 22)
            {
                LVLnum = 22;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin22")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 23)
            {
                LVLnum = 23;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin24")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 25)
            {
                LVLnum = 25;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin25")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 26)
            {
                LVLnum = 26;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin26")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 27)
            {
                LVLnum = 27;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin27")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 28)
            {
                LVLnum = 28;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin28")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 29)
            {
                LVLnum = 29;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin29")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 30)
            {
                LVLnum = 30;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin30")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 31)
            {
                LVLnum = 31;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin31")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 32)
            {
                LVLnum = 32;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin32")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 33)
            {
                LVLnum = 33;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin33")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 34)
            {
                LVLnum = 34;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin34")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 35)
            {
                LVLnum = 35;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin35")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 36)
            {
                LVLnum = 36;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin36")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 37)
            {
                LVLnum = 37;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin37")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 38)
            {
                LVLnum = 38;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin39")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 40)
            {
                LVLnum = 40;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin40")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 41)
            {
                LVLnum = 41;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin41")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 42)
            {
                LVLnum = 42;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin42")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 43)
            {
                LVLnum = 43;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin43")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 44)
            {
                LVLnum = 44;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin44")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 45)
            {
                LVLnum = 45;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "bin45")
        {
            GetComponent<Rigidbody2D>().drag = 50;
            Panel.SetActive(true);
            if (LVLnum <= 46)
            {
                LVLnum = 46;
            }
            PlayerPrefs.SetInt("LVL", LVLnum);
        }
        if (collision.collider.tag == "secret")
        {
            transform.position = secretpos.transform.position;
        }

    }

}
