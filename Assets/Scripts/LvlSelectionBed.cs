using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelectionBed : MonoBehaviour
{

    public GameObject[] Lvlss;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int L = Ball.LVLnum; L > 15; L--)
        {
            Lvlss[L - 17].SetActive(false);
        }

    }

    public void LVL1()
    {
        SceneManager.LoadScene(21);
    }
    public void LVL2()
    {
        SceneManager.LoadScene(22);
    }
    public void LVL3()
    {
        SceneManager.LoadScene(23);
    }
    public void LVL4()
    {
        SceneManager.LoadScene(24);
    }
    public void LVL5()
    {
        SceneManager.LoadScene(25);
    }
    public void LVL6()
    {
        SceneManager.LoadScene(26);
    }
    public void LVL7()
    {
        SceneManager.LoadScene(27);
    }
    public void LVL9()
    {
        SceneManager.LoadScene(28);
    }
    public void LVL10()
    {
        SceneManager.LoadScene(29);
    }
    public void LVL11()
    {
        SceneManager.LoadScene(30);
    }
    public void LVL12()
    {
        SceneManager.LoadScene(31);
    }
    public void LVL13()
    {
        SceneManager.LoadScene(32);
    }
    public void LVL14()
    {
        SceneManager.LoadScene(33);
    }
    public void LVL15()
    {
        SceneManager.LoadScene(34);
    }
    public void Back()
    {
        SceneManager.LoadScene(18);
    }
}
