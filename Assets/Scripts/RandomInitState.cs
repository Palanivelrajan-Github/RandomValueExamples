using UnityEngine;

[ExecuteInEditMode]
public class RandomInitState : MonoBehaviour
{
    private float[] _noiseValues;

    private void OnEnable()
    {
        Random.InitState(2); // test with 3,4... 100
        _noiseValues = new float[10];
        for (int i = 0; i < _noiseValues.Length; i++)
        {
            //_noiseValues[i] = Random.value;
            _noiseValues[i] = Random.Range(0, 2);
            Debug.Log(_noiseValues[i]);
        }
    }
}
