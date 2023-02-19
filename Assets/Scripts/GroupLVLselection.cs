using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroupLVLselection : MonoBehaviour
{

    public GameObject BedLock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.LVLnum > 15)
        {
            BedLock.SetActive(false);
        }
    }

    public void LivingRoom()
    {
        SceneManager.LoadScene(3);
    }
    public void BedRoom()
    {
        SceneManager.LoadScene(19);
    }
    public void Kitchen()
    {
        SceneManager.LoadScene(20);
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
