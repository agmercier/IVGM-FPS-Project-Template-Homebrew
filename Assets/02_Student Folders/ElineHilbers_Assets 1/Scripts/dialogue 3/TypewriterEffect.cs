using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypewriterEffect : MonoBehaviour
{
    //gives the speed of the effect     serializefield = this way you can edit the value in unity
    [SerializeField] private float typewriterSpeed = 50f;

    //runs the coroutine    textToType= string we want to type    textLabel= label we want to type it on
   public Coroutine Run(string textToType, TMP_Text textLabel)
    {
        return StartCoroutine(TypeText(textToType, textLabel));
    }

    //Types the text    float t = elapsed time since we begun typing    charIndex = how many characters we wanna type on screen at a given frame
    private IEnumerator TypeText(string textToType, TMP_Text textLabel)
    {
        //makes sure textbox starts of blank before typing
        textLabel.text = string.Empty;
        
        float t = 0;
        int charIndex = 0;

        while(charIndex < textToType.Length) 
        {
            t += Time.deltaTime * typewriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textLabel.text = textToType.Substring(0, charIndex);
            
            yield return null;        
        }

        textLabel.text = textToType;
    }
}
