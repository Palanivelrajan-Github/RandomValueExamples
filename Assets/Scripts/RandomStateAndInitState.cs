using System;
using UnityEngine;
using Random = UnityEngine.Random;

[ExecuteInEditMode]
public class RandomStateAndInitState : MonoBehaviour
{
    private void OnGUI()
    {

        if (GUI.Button(new Rect(10, 10, 100, 50), "Random"))
        {
            const int initialSeed = 1;

            Random.InitState(initialSeed); // cannot be retrieved

            PrintRandom("Step 1");
            PrintRandom("Step 2");

            var stateBeforeStep3 = Random.state; // can be serialized

            PrintRandom("Step 3");
            PrintRandom("Step 4");

            Random.state = stateBeforeStep3;

            PrintRandom("Step 5");
            PrintRandom("Step 6");

            Random.InitState(initialSeed);

            PrintRandom("Step 7");
            PrintRandom("Step 8");
        }

    }

    
    private static void PrintRandom(string label)
    {
        Debug.Log($"{label} - RandomValue {Random.Range(0, 100)}");
    }
}