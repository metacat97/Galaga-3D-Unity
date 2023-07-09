using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Color pathColor = Color.green;
    
    Transform[] objArray;
    public List<Transform> pahtObjList = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        //STRAIGHT PATH
        Gizmos.color = pathColor;
        //FILL THE ARRAY
        objArray = GetComponentsInChildren<Transform>();
        //ClearObj
        pahtObjList.Clear();
        //all children into list
        foreach(Transform obj in objArray)
        {
            if(obj != this.transform)
            {
                pahtObjList.Add(obj);
            }
        }
    }
}
