using UnityEngine;


public class Ball : MonoBehaviour
{
   public TMPro.TMP_Text ScoreText;


   private int _groundHitCount;
   private int _streakScore;


   private Rigidbody2D _rb;


   void Start()
   {
       _rb = GetComponent<Rigidbody2D>();
   }


   void UpdateScoreText()
      {
       ScoreText.text = $"Score: {_streakScore}";
   }


   private void OnCollisionEnter2D(Collision2D other)
   {
       switch (other.collider.gameObject.name)
       {
           case "Ground":
               _streakScore = 0;
               _groundHitCount++;
               if (_groundHitCount == 2)
               {
                   Debug.Log("Game over!");
               }
               UpdateScoreText();
               break;


           case "PlayerHead":
               // we reset the ground hit count because we hit the player's head
               _groundHitCount = 0;
               _streakScore++;
               UpdateScoreText();


               break;


           default:
               break;
       }
   }
}
