using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Accounts : MonoBehaviour
{
    public string Name;
    public string secondName;
    //public GameObject sus;
    public Text mainText;
    public Text secondmainText;
    public Text fieldText;
    public Text secondfieldText;
    public Text PlayerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getName()
    {
        Name = fieldText.text;
        mainText.text = Name;
        PlayerName.text = Name;
    }
    public void getSecondName()
    {
        secondName = secondfieldText.text;
        secondmainText.text = secondName;
        PlayerName.text = secondName;
    }
}
