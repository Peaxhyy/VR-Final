using System.Collections;
using System.Collections.Generic;
using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersSafetyHazards : MonoBehaviour
{
    public int score = 0;
    public SafetyHazardsQuiz SafetyHazardsQuiz;
    public void _CheckAnswers(int answer){
        score = score + answer;
        SafetyHazardsQuiz._ChangeQuestion();
    }
}
