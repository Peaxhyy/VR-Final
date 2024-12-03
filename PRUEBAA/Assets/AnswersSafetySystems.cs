using System.Collections;
using System.Collections.Generic;
using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersSafetySystems : MonoBehaviour
{
    public int score = 0;
    public SafetySystemsQuiz SafetySystemsQuiz;
    public void _CheckAnswers(int answer){
        score = score + answer;
        SafetySystemsQuiz._ChangeQuestion();
    }
}
