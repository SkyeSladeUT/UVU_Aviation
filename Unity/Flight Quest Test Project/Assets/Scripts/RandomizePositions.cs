using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePositions : MonoBehaviour
{
    public List<GameObject> RandomizeObjects;
    public List<Vector3> Locations;

    private List<Vector3> _remainingLocations;
    private int randIndexLocations, randIndexObject;
    private List<GameObject> objectsLeft;

    public bool useInitPositions;

    public int numRandomized;
    private Transform pos1;
    private List<int> randnums;
    private List<int> listNums;
    private List<int> remainingNum;

    private void Start()
    {
        if (useInitPositions)
        {
            Locations = new List<Vector3>();
            foreach (var obj in RandomizeObjects)
            {
                Locations.Add(obj.transform.position);
            }
        }
        listNums = new List<int>();
        for (int i = 0; i < RandomizeObjects.Count; i++)
        {
            listNums.Add(i);
        }
    }

    public void RandomizeAll()
    {
        _remainingLocations = Locations;
        foreach (var obj in RandomizeObjects)
        {
            randIndexLocations = Random.Range(0, _remainingLocations.Count - 1);
            obj.transform.position = _remainingLocations[randIndexLocations];
            _remainingLocations.RemoveAt(randIndexLocations);
        }
    }

    public void RandomizeAmount()
    {
        if (numRandomized > 1)
        {
            if (numRandomized > RandomizeObjects.Count)
            {
                numRandomized = RandomizeObjects.Count;
            }
            remainingNum = listNums;
            randnums = new List<int>();
            for (int i = 0; i < numRandomized; i++)
            {
                randIndexLocations = Random.Range(0, remainingNum.Count - 1);
                randnums.Add(remainingNum[randIndexLocations]);
                remainingNum.RemoveAt(randIndexLocations);
            }
            for (int i = 0; i < numRandomized-1; i++)
            {
                RandomizeObjects[randnums[i]].transform.position = Locations[randnums[i+1]];
            }
            RandomizeObjects[randnums[randnums.Count - 1]].transform.position = Locations[randnums[0]];
        }

    }  
}
