using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    public GameObject panel;
    public Image flag;
    public Image Monuments;
    public Text population;
    public Text capital;
    public Text countryName;
    private GameObject countryTarget;
    public GameObject bal;
    public Dropdown dd;
    private string country;
    public Collider balloonCollider;
    public Collider countryCollider;
    public List<CountryInfo> Countries;
    private bool state = true;
    public void Start()
    {
        country = dd.options[dd.value].text;
        countryTarget = GameObject.FindGameObjectWithTag(country);
        
    }
    public void goToCountry()
    {
        country = dd.options[dd.value].text;
        countryTarget = GameObject.FindGameObjectWithTag(country);
        bal.GetComponent<Travel>().target = countryTarget.transform;
    }

    public void Update()
    {
        countryCollider = countryTarget.GetComponent<Collider>();
        if (balloonCollider.bounds.Intersects(countryCollider.bounds))
        {
            if (state == true)
            {
                setPanel();
                panel.SetActive(true);
                state = false;
            }
        }
        else
        {
            panel.SetActive(false);
            state = true;
        }
    }


    public void setPanel()
    {
        for (int i = 0; i < Countries.Count; i++)
        {
            if (Countries[i].countryName.Equals(country))
            {
                countryName.text = Countries[i].countryName.ToUpper();
                flag.GetComponent<Image>().sprite = Countries[i].flag;
                Monuments.GetComponent<Image>().sprite = Countries[i].Monuments;
                population.text = Countries[i].population;
                 capital.text = Countries[i].capital; 
            }
        }
    }
}
