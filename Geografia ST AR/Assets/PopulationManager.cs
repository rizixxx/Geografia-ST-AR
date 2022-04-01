using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulationManager : MonoBehaviour
{

    public List<Material> Materials = new List<Material>();
    public List<GameObject> Continents = new List<GameObject>();
    public Slider slider;
    private int[,] popul = { { 13, 479, 95, 140, 2 }, {12, 602, 90, 187, 2},
    {24, 749, 95, 266, 2}, {59, 937, 120, 401, 6}, {422, 1701, 277, 604, 16},
    {568, 2398, 408, 676, 21}, {721, 3168, 622, 722, 26}, {830, 3680, 796, 728, 29},
    {1200, 6350, 1020, 1080, 48}, {2057, 6752, 2350, 1143, 57} };
    public void Start()
    {
        paintCont(0);
    }
    public void paintAll()
    {
        float currentSliderValue = slider.value;
        switch (currentSliderValue)
        {
            case 0:
                paintCont((int)currentSliderValue);
                break;
            case 1:
                paintCont((int)currentSliderValue);
                break;
            case 2:
                paintCont((int)currentSliderValue);
                break;
            case 3:
                paintCont((int)currentSliderValue);
                break;
            case 4:
                paintCont((int)currentSliderValue);
                break;
            case 5:
                paintCont((int)currentSliderValue);
                break;
            case 6:
                paintCont((int)currentSliderValue);
                break;
            case 7:
                paintCont((int)currentSliderValue);
                break;
            case 8:
                paintCont((int)currentSliderValue);
                break;
            case 9:
                paintCont((int)currentSliderValue);
                break;

        }
    }

    private void paintCont(int val)
    {
        for (int i = 0; i<=4; i++)
        {
            if(popul[val, i] <= 400)
            {
                setContColor(Continents[i].name, Materials[0]);
            }
            else if(popul[val, i] <= 800)
            {
                setContColor(Continents[i].name, Materials[1]);
            }
            else if (popul[val, i] <= 1200)
            {
                setContColor(Continents[i].name, Materials[2]);
            }
            else if (popul[val, i] <= 2000)
            {
                setContColor(Continents[i].name, Materials[3]);
            }
            else if (popul[val, i] <= 3000)
            {
                setContColor(Continents[i].name, Materials[4]);
            }
            else
            {
                setContColor(Continents[i].name, Materials[5]);
            }
        }
    }

    private void setContColor(string continent, Material mat)
    {
        try
        {
            for (int j = 0; j <= GameObject.FindGameObjectWithTag(continent).transform.childCount; j++)
            {
                GameObject.FindGameObjectWithTag(continent).transform.GetChild(j).GetComponent<MeshRenderer>().material = mat;
            }
        }
        catch
        {
            Debug.Log("Out of Bounds");
        }
    }

}
