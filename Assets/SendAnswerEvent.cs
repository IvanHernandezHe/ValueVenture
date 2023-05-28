using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SendAnswerEvent : MonoBehaviour
{

    [SerializeField] private TMP_InputField userAnswer;
    [SerializeField] private TMP_Text gameResponse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sendAnswer()
    {
        //userAnswer.text = userAnswer;
        Debug.Log(userAnswer.text);
        gameResponse.text = userAnswer.text;

    }

}
