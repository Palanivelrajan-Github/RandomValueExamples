using UnityEngine;
using UnityEngine.Serialization;

public class RandomValue : MonoBehaviour
{

    public Color color;
    void Start()
    {
        Color randomColor = RandomColor();
        color = randomColor;
        print(randomColor);

    }

    // Generate a random color value.
    Color RandomColor()
    {
        // A different random value is used for each color component (if
        // the same is used for R, G and B, a shade of grey is produced).
        return new Color(Random.value, Random.value, Random.value);
    }
    
}
