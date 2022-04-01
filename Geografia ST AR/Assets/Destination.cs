using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destination : MonoBehaviour
{
    // Start is called before the first frame update

    public Dropdown OceanList;
    string ocean_name;
    GameObject ocean_dest;
    PathCreation.PathCreator ocean_path;
    public GameObject ship;


    public void travelTo()
    {
        Destroy(ship.GetComponent<PathCreation.Examples.PathFollower>());
        ocean_name = OceanList.options[OceanList.value].text;
        ocean_dest = GameObject.FindGameObjectWithTag(ocean_name);
        ocean_path = ocean_dest.GetComponent<PathCreation.PathCreator>();
        ship.AddComponent<PathCreation.Examples.PathFollower>().pathCreator = ocean_path;
    }

    public void printname()
    {
        Debug.Log(ocean_name);
    }
    public void backToPort()
    {

        Destroy(ship.GetComponent<PathCreation.Examples.PathFollower>());
        switch (ocean_name)
        {
            case "Ειρηνικός (Ανατολικά)":
                ocean_name += "Λιμάνι";
                ocean_dest = GameObject.FindGameObjectWithTag(ocean_name);
                ocean_path = ocean_dest.GetComponent<PathCreation.PathCreator>();
                ship.AddComponent<PathCreation.Examples.PathFollower>().pathCreator = ocean_path;
                break;
            case "Ατλαντικός":
                ocean_name += "Λιμάνι";
                ocean_dest = GameObject.FindGameObjectWithTag(ocean_name);
                ocean_path = ocean_dest.GetComponent<PathCreation.PathCreator>();
                ship.AddComponent<PathCreation.Examples.PathFollower>().pathCreator = ocean_path;
                break;
            case "Ινδικός":
                ocean_name += "Λιμάνι";
                ocean_dest = GameObject.FindGameObjectWithTag(ocean_name);
                ocean_path = ocean_dest.GetComponent<PathCreation.PathCreator>();
                ship.AddComponent<PathCreation.Examples.PathFollower>().pathCreator = ocean_path;        
                break;
            case "Ειρηνικός (Δυτικά)":
                ocean_name += "Λιμάνι";
                ocean_dest = GameObject.FindGameObjectWithTag(ocean_name);
                ocean_path = ocean_dest.GetComponent<PathCreation.PathCreator>();
                ship.AddComponent<PathCreation.Examples.PathFollower>().pathCreator = ocean_path;
                break;
            case "Αρκτικός":
                ocean_name += "Λιμάνι";
                ocean_dest = GameObject.FindGameObjectWithTag(ocean_name);
                ocean_path = ocean_dest.GetComponent<PathCreation.PathCreator>();
                ship.AddComponent<PathCreation.Examples.PathFollower>().pathCreator = ocean_path;
                break;
        }
    }
}
