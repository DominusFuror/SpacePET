using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        
    }



    [SerializeField] AudioClip ping;
    [SerializeField] GameObject dialog;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Text textGo;
    [SerializeField] Button button;

    [SerializeField] TouchInputSc inputSystem;
    [SerializeField] PlayerFireManager fireManager;

    string text = "I'm a cat, and i dont know what ama doing at space, wtf??!!!!";

    public void StartDialog()
    {
        StartCoroutine(DialogTextStream());
    }
    IEnumerator DialogTextStream()
    {
        dialog.SetActive(true);
        yield return new WaitForSeconds(2);
        inputSystem.enabled = false;
        fireManager.enabled = false;
        for (int i = 0; i < text.Length; i++)
        {
            audioSource.pitch = Random.Range(0.9f, 1.1f);
            audioSource.Play();
            textGo.text += text[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(1);
        button.gameObject.SetActive(true);
        yield  break;
    }
    public void Countinune()
    {
        inputSystem.enabled = true;
        fireManager.enabled = true;
        dialog.SetActive(false);


    }
}
