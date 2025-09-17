// PlayerLife.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int life = 3;

    public void Damage()
    {
        life--;

        if (life <= 0)
        {
            SceneManager.LoadScene("OP");
        }

        // ステージ4に戻す
        SceneManager.LoadScene("Stage4");
    }
}

