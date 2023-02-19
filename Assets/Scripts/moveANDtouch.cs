using System.Collections;
using System.Collections.Generic;
using UnityEngine.Android;
using UnityEngine;

public class moveANDtouch : MonoBehaviour
{

    public GameObject Allhand;
    public GameObject Ball;

    private Animator handAnim;

    // Start is called before the first frame update
    void Start()
    {
        handAnim = Allhand.GetComponent<Animator>();
        Ball.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Allhand.transform.position = new Vector2(mousePos.x, 3.75f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Ball.GetComponent<Rigidbody2D>().gravityScale = 1;
            handAnim.SetTrigger("LetItGo");
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Allhand.transform.position = new Vector2(touchPos.x, 946);
            }
            if (touch.phase == TouchPhase.Ended)
            {
                Ball.GetComponent<Rigidbody2D>().gravityScale = 1;
                handAnim.SetTrigger("LetItGo");
            }
        }

    }
}
