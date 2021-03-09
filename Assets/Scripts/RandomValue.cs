using UnityEngine;

public class RandomValue : MonoBehaviour
{
    public Color color;


    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 150, 50), "Random Color"))
        {
            var randomColor = RandomColor();
            color = randomColor;
            print(randomColor);
        }
    }

    // Generate a random color value.
    private Color RandomColor()
    {
        // A different random value is used for each color component (if
        // the same is used for R, G and B, a shade of grey is produced).
        return new Color(Random.value, Random.value, Random.value);
    }
}