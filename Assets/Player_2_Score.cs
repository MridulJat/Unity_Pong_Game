using UnityEngine;
using UnityEngine.UI;

public class Player_2_Score : MonoBehaviour
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
        Player_text.text = "Player 2 Score: " + Player_Goal.Player_2_Score.ToString();
    }
}
