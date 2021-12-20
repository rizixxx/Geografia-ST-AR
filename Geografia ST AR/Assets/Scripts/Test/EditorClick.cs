using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorClick : MonoBehaviour
{
    // Start is called before the first frame update
    AnswerScript ans;
    AnswerScript answer = new AnswerScript();
    
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    switch (hit.collider.name.ToString())
                    {
                        case "Answer_1":
                            //answer.Answer();
                            break;
                        case "Answer_2":
                            //answer.Answer();
                            break;
                        case "Answer_3":
                            //answer.Answer();
                            break;
                        case "Answer_4":
                           // answer.Answer();
                            break;
                    }
                }
            }
        }
    }
}


