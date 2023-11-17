using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutController : MonoBehaviour
{  public Image uiImage; // The UI image to change opacity
   public float increaseAmount = 0.1f; // The amount to increase opacity by
   private  Color color;
  public float duration = 1f; 

private void Awake(){
   
    color = uiImage.color;
    //color.a = 0f;
}

   private void OnTriggerStay2D(Collider2D other)
   {

     Debug.Log("SOMETHING entered");
       if (other.CompareTag("Player")) // Check if the object is tagged as "Player"
       {

        Debug.Log("Player entered");
            // Get the current color of the UI image
           StartCoroutine(FadeInImage(duration)); 
       }
   }

    private void OnTriggerExit2D(Collider2D other)
 {
     if (other.CompareTag("Player")) // Check if the object is tagged as "Player"
     {
         StartCoroutine(FadeOutImage(duration)); // Start the fade out coroutine
     }
 }

 private IEnumerator FadeOutImage(float duration)
 {
     Color color = uiImage.color; // Get the current color of the UI image
     float startAlpha = color.a; // The initial alpha value
     float endAlpha = 0f; // The final alpha value

     float elapsedTime = 0f;

     while (elapsedTime < duration)
     {
         elapsedTime += Time.deltaTime; // Accumulate the elapsed time
         float alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration); // Calculate the current alpha value
         color.a = alpha; // Set the new alpha value
         uiImage.color = color; // Apply the new color to the UI image
         yield return null; // Wait for the next frame
     }

     color.a = endAlpha; // Ensure the final alpha value is exactly 0
     uiImage.color = color; // Apply the final color to the UI image
 }

   private IEnumerator FadeInImage(float duration)
  {
      Color color = uiImage.color; // Get the current color of the UI image
      float startAlpha = color.a; // The initial alpha value
      float endAlpha = 1f; // The final alpha value

      float elapsedTime = 0f;

      while (elapsedTime < duration)
      {
          elapsedTime += Time.deltaTime; // Accumulate the elapsed time
          float alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration); // Calculate the current alpha value
          color.a = alpha; // Set the new alpha value
          uiImage.color = color; // Apply the new color to the UI image
          yield return null; // Wait for the next frame
      }
}
}