using UnityEngine;
using UnityEngine.UI;

public class Player_1_Score : MonoBehaviour
{
    private Text Player_text;
    // Start is called before the first frame update
    void Start()
    {
        Player_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Player_text.text = "Player 1 Score: " + Player_Goal.Player_1_Score.ToString();
    }
}
