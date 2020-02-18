using UnityEngine;
using UnityEngine.UI;

public class Balloon : MonoBehaviour {
    private Text ScoreText;
    bool gameStart;
    public GameObject GameOverText;
    public bool gameOver = false;
    public Animator _animator;
    private void Start () {
        ScoreText = GameManager.gm.GameplayUI.Find ("ScorePlaceholder").Find ("Score").GetComponent<Text> ();
        _animator.enabled = false;
    }
	
	private void Update () {
        ScoreText.text = Mathf.Max(0, Mathf.FloorToInt(transform.position.y)).ToString();  
	}

	private void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Obstacle") {
            AudioManager.getInstance().Stop("Theme");
            AudioManager.getInstance().Play("PlayerDeath");
			print ("GAME OVER!");
            //SceneManager.LoadScene ("Gameplay");
            _animator.enabled = true;
            Invoke("EndGame", 0.30f);
            
     		}
	}

    private void OnTriggerEnter2D(Collider2D other)//  when reach end of level 
    {
         if (other.tag == "LevelEnd")
        {
            other.tag = "Untagged"; //Can trigger only once (needs, bcz balloon has 2 colliders)
            GameManager.gm.lm.GenerateLevel();
        }
    }

    public void EndGame()
    {

        GameObject.Find("PauseButtn").GetComponent<Button>().enabled = false;
        GameOverText.SetActive(true);
        gameOver = true;
        Time.timeScale = 0;

       }

}