using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager
{

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject prefeb = Resources.Load<GameObject>($"Prefebs/{path}");
        if(prefeb == null)
        {
            Debug.Log($"Failed to load prefeb : {path}");
            return null;
        }

        return Object.Instantiate(prefeb, parent);
    }

}
