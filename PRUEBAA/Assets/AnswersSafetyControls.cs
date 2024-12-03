using System.Collections;
using System.Collections.Generic;
using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersSafetyControls : MonoBehaviour
{
    public int score = 0;
    public SafetyControlsQuiz SafetyControlsQuiz;
    public void _CheckAnswers(int answer){
        score = score + answer;
        SafetyControlsQuiz._ChangeQuestion();
    }
}
