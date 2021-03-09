using UnityEngine;
using Random = UnityEngine.Random;

[ExecuteInEditMode]
public class RandomOtherExamples : MonoBehaviour
{

    #region Example 1

    /*public float[] probsList; 

    private void OnEnable()
    {
        print(Choose(probsList)); 
    }
    private static float Choose (IReadOnlyList<float> probs) {

        float total = 0;

        foreach (float elem in probs) {
            total += elem;
        }

        float randomPoint = Random.value * total;
       
        print(randomPoint);
        
        for (int i= 0; i < probs.Count; i++) {
            if (randomPoint < probs[i]) {
                print(randomPoint);
                return i;
            }
            else {
                randomPoint -= probs[i];
                
            }
        }
        return probs.Count - 1;
    }*/

    #endregion

    #region Example 2
     /*public int[] deckList;

     private void OnEnable()
     {

         print(Shuffle(deckList));
     }


     private static int Shuffle (int[] deck) {
            for (int i = 0; i < deck.Length; i++) {
                int temp = deck[i];
                int randomIndex = Random.Range(0, deck.Length);
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
                
            }
            return deck.Length;
            
        }*/

    #endregion

    #region Example 3

    public Transform[] listofSpawnPoints;
    public Transform[] FinalRandomSpawnPoints;
    
    private const int RequireRandomSpawbPoints = 3;

    private void OnEnable()
    {
        
        FinalRandomSpawnPoints= ChooseSet(RequireRandomSpawbPoints);

    }
    private Transform[] ChooseSet (int numRequired) {
        Transform[] result = new Transform[numRequired];

        int numToChoose = numRequired;

        for (int numLeft = listofSpawnPoints.Length; numLeft > 0; numLeft--) {

            float prob = (float)numToChoose/(float)numLeft;

            if (Random.value <= prob) {
                numToChoose--;
                result[numToChoose] = listofSpawnPoints[numLeft - 1];

                if (numToChoose == 0) {
                    break;
                }
            }
        }
        return result;
    }

    #endregion
  
  
}
