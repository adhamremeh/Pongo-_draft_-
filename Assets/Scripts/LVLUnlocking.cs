using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LVLUnlocking : MonoBehaviour
{

    public GameObject[] Locks;
    public int lvls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lvls = Ball.LVLnum;

            for (int L = Ball.LVLnum; L > 0; L--)
            { 
                Locks[L - 2].SetActive(false);
            }
        
    }

    public void LVL1()
    {
        SceneManager.LoadScene(4);
    }
    public void LVL2()
    {
        SceneManager.LoadScene(5);
    }
    public void LVL3()
    {
        SceneManager.LoadScene(6);
    }
    public void LVL4()
    {
        SceneManager.LoadScene(7);
    }
    public void LVL5()
    {
        SceneManager.LoadScene(8);
    }
    public void LVL6()
    {
        SceneManager.LoadScene(9);
    }
    public void LVL7()
    {
        SceneManager.LoadScene(10);
    }
    public void LVL9()
    {
        SceneManager.LoadScene(11);
    }
    public void LVL10()
    {
        SceneManager.LoadScene(12);
    }
    public void LVL11()
    {
        SceneManager.LoadScene(13);
    }
    public void LVL12()
    {
        SceneManager.LoadScene(14);
    }
    public void LVL13()
    {
        SceneManager.LoadScene(15);
    }
    public void LVL14()
    {
        SceneManager.LoadScene(16);
    }
    public void LVL15()
    {
        SceneManager.LoadScene(17);
    }
    public void Back()
    {
        SceneManager.LoadScene(18);
    }
}
