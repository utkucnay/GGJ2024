using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PickerArea : MonoBehaviour
{
    List<Picker> pickers;

    public List<Picker> GetPickers() 
    {
        if(pickers == null || pickers.Count != transform.childCount)
            pickers = transform.GetComponentsInChildren<Picker>().ToList();

        return pickers;
    }

    public int GetPickersLenght() 
    {
        return pickers.Count;
    }
}
