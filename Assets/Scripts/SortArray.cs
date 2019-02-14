using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortArray : MonoBehaviour
{
    public int[] myArray = { 9,2,4,2,4,9,16,8 };
    public Dictionary<int, int> myDictionary = new Dictionary<int, int>();
    public List<int> myList = new List<int>();

    private void Start()
    { 
        Debug.Log(RemoveAndSort(myArray));
    }
    //Function to remove duplicates in an array, sort array and return
    public int[] RemoveAndSort(int[] array)
    {
        //Loop through the array
        for(int i = 0; i < array.Length; i++)
        {
            //Check if current index value is containted in dictionary, if not write to dictionary/list to remove duplicates
            if (!myDictionary.ContainsValue(array[i]))
            {
                myDictionary.Add(myDictionary.Count, array[i]);
                myList.Add(array[i]);
            }            
        }
        //Sort and return
        myList.Sort();
        myArray = myList.ToArray();
        return myArray;
    }
}
