using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickDetector : MonoBehaviour
{
    earthmovearound script1;
    U10PS_DissolveOverTime script;
    private int index = 0;
    private Vector3[,] position = new Vector3[8, 2];
    private double points = 0;
    private Text mypoints;
    private Text mymessage;
    public GameObject ob;
    private void position_set()
    {
        position[0, 0] = new Vector3(3.03f, 6.66f, -3f);
        position[0, 1] = new Vector3(0.7f, 0.7f, 0.7f);
        position[1, 0] = new Vector3(5.76f, 7.28f, -0.63f);
        position[1, 1] = new Vector3(1.6f, 1.6f, 1.6f);
        position[2, 0] = new Vector3(6.98f, 5.27f, 1.56f);
        position[2, 1] = new Vector3(1.6f, 1.6f, 1.6f);
        position[3, 0] = new Vector3(8.087f, 6.59f, -1.4f);
        position[3, 1] = new Vector3(0.95f, 0.95f, 0.95f);
        position[4, 0] = new Vector3(10.79f, 6.47f, 2.5f);
        position[4, 1] = new Vector3(2.5f, 2.5f, 2.5f);
        position[5, 0] = new Vector3(13.75f, 5.035f, -3.5f);
        position[5, 1] = new Vector3(0.0025f, 0.0025f, 0.0025f);
        position[6, 0] = new Vector3(16.25f, 5.93f, 0.37f);
        position[6, 1] = new Vector3(1.6f, 1.6f, 1.6f);
        position[7, 0] = new Vector3(18.35f, 5.5f, -0.03f);
        position[7, 1] = new Vector3(1.55f, 1.55f, 1.55f);

    }
    private void Start()
    {
        position_set();
        mypoints = GameObject.FindGameObjectWithTag("Points").GetComponent<Text>();
        mymessage = GameObject.FindGameObjectWithTag("Score_Message").GetComponent<Text>();

    }
    private void planet_placement(int ind, string planet_container, string planet, string planet_extra)
    {

            GameObject.FindGameObjectWithTag(planet_container).transform.localPosition = position[ind, 0];
            GameObject.FindGameObjectWithTag(planet_container).transform.localScale = position[ind, 1];
            try
            {
                dissolve_enable(planet);
                if (!planet_extra.Equals(""))
                {
                    dissolve_enable(planet_extra);
                }
                earthmovearound_enable(planet_container);
            }
            catch
            {
                Debug.LogError("Script not found on current Object.");
            }
    }
    private void dissolve_enable(string tag)
    {
        script = GameObject.FindGameObjectWithTag(tag).GetComponent<U10PS_DissolveOverTime>();
        script.enabled = true;
    }
    private void earthmovearound_enable(string tag)
    {
        script1 = GameObject.FindGameObjectWithTag(tag).GetComponent<earthmovearound>();
        script1.enabled = true;

    }
    private void message()
    {
        if (points <= 50)
        {
            mymessage.text = "<b>Προσπαθήστε ξανά!</b> \n\nΤο σκορ σας είναι <b>" + points + "/100</b> πόντοι!";
        }
        else if(points <= 62.5)
        {
            mymessage.text = "<b>Σχεδόν καλά!</b> \n\nΤο σκορ σας είναι <b>" + points +"/100</b> πόντοι!";
        }
        else if (points <= 75)
        {
            mymessage.text = "<b>Καλά!</b> \n\nΤο σκορ σας είναι <b>" + points + "/100</b> πόντοι!";
        }
        else if (points <= 87.5)
        {
            mymessage.text = "<b>Πολύ καλά!</b> \n\nΤο σκορ σας είναι <b>" + points + "/100</b> πόντοι!";
        }
        if (points <= 100)
        {
            mymessage.text = "<b>Άριστα!</b> \n\nΤο σκορ σας είναι \n<b>" + points + "/100</b> πόντοι!";
        }
    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    switch (hit.collider.name.ToString())
                    {
                        case "Mercury_Planet":
                            if (index == 0)
                            {
                                planet_placement(index, "Mercury", "Mercury_Planet", "");
                                points += 12.5;
                                index++;
                            }
                            else if(GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                        case "Venus_Planet":
                            if (index == 1)
                            {
                                planet_placement(index, "Venus", "Venus_Planet", "");
                                points += 12.5;
                                index++;
                            }
                            else if (GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                        case "Earth_Planet":
                            if (index == 2)
                            {
                                planet_placement(index, "Earth", "Earth_Planet", "");
                                points += 12.5;
                                index++;
                            }
                            else if (GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                        case "Mars_Planet":
                            if (index == 3)
                            {
                                planet_placement(index, "Mars", "Mars_Planet", "");
                                points += 12.5;
                                index++;
                            }
                            else if (GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                        case "Jupiter_Planet":
                            if (index == 4)
                            {
                                planet_placement(index, "Jupiter", "Jupiter_Planet", "");
                                points += 12.5;
                                index++;
                            }
                            else if (GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                        case "Saturn_Planet":
                            if (index == 5)
                            {
                                planet_placement(index, "Saturn", "Saturn_Planet", "Saturn_Ring");
                                points += 12.5;
                                index++;
                            }
                            else if (GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                        case "Uranus_Planet":
                            if (index == 6)
                            {
                                planet_placement(index, "Uranus", "Uranus_Planet", "");
                                points += 12.5;
                                index++;
                            }
                            else if (GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                        case "Neptune_Planet":
                            if (index == 7)
                            {
                                planet_placement(index, "Neptune", "Neptune_Planet", "");
                                points += 12.5;
                                Destroy(GameObject.FindGameObjectWithTag("Shelf"));
                                message();
                                ob.GetComponent<Canvas>().enabled = true;
                                index++;
                            }
                            else if (GameObject.FindGameObjectWithTag("Shelf") != null)
                            {
                                points -= 2.5;
                            }
                            break;
                    }

                }
            }
        }
        mypoints.text = points.ToString();

        /*
        
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    switch (hit.collider.name.ToString()) {
                        case "Sun":
                            Debug.Log("Hlios");
                            break;
                        case "Mercury_Planet":
                            if (index == 1){
                                Debug.Log("Ermis");
                                index++;
                                Debug.Log(index);
                            }
                            break;
                        case "Earth_Planet":
                            if (index == 2)
                            {
                                index++;
                                Debug.Log(index);
                            }
                            break;
                        case "Venus_Planet":
                            if (index ==3)
                            {
                                index++;
                                Debug.Log(index);
                            }
                            break;
                        case "Mars_Planet":
                            if (index ==4)
                            {
                                index++;
                                Debug.Log(index);
                            }
                            break;
                        case "Jupiter_Planet":
                            if (index ==5)
                            {
                                index++;
                                Debug.Log(index);
                            }
                            break;
                        case "Uranus_Planet":
                            if (index ==6)
                            {
                                index++;
                                Debug.Log(index);
                            }
                            break;
                        case "Neptune_Planet":

                            if (index ==7)
                            {
                                GameObject.FindGameObjectWithTag("Neptune").transform.localPosition = set_pos;                              script = GameObject.FindGameObjectWithTag("Neptune_Planet").GetComponent<U10PS_DissolveOverTime>();
                                script.enabled = true;
                                index++;
                            }
                            break;
                    }
                        

                }
            }
        }
        
            Vector3 previous_pos = GameObject.FindGameObjectWithTag(tag).transform.position;
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                GameObject.FindGameObjectWithTag(tag).transform.position = new Vector3(40, 2, 5.4f);
                Debug.Log(GameObject.FindGameObjectWithTag("Sun").transform.position);
            }
            else
            {
                condition = true;
            }
        
    }
#endif*/

    }

    }