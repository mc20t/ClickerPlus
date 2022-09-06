using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public BigInteger Score = 0;
    public BigInteger SokrScore = 0;
    public BigInteger Click = 1;
    public BigInteger Var_ = 1000;
    public Text ScoreText;

    void Start()
    {
        for (int i = 0; i < 13; i++) Var_ *= 1000; // 1 000 000 000 000 000 000 000 000 000 000 000 000 000 000
        Check();
    }

    public void Check()
    {
        SokrScore = Score;
        int k = 0;

        while (SokrScore >= 1000)
        {
            SokrScore /= 1000;
            k++;
        }

        if (Score < 100000000)
            ScoreText.text = Score + "";
        else if (Score >= 100000000 && Score < Var_)
        {
            if (k == 3) ScoreText.text = SokrScore + "млр";
            if (k == 4) ScoreText.text = SokrScore + "тлн";
            if (k == 5) ScoreText.text = SokrScore + "крлн";
            if (k == 6) ScoreText.text = SokrScore + "ктлн";
            if (k == 7) ScoreText.text = SokrScore + "склн";
            if (k == 8) ScoreText.text = SokrScore + "сплн";
            if (k == 9) ScoreText.text = SokrScore + "оклн";
            if (k == 10) ScoreText.text = SokrScore + "ннлн";
            if (k == 11) ScoreText.text = SokrScore + "дклн";
            if (k == 12) ScoreText.text = SokrScore + "эдклн";
            if (k == 13) ScoreText.text = SokrScore + "додклн";
        }
        else
        {
            SokrScore = Score;

            while (SokrScore >= 1000)
            {
                SokrScore /= 10;
                k++;
            }

            ScoreText.text = SokrScore + $" x 10^{k}";
        }
    }

    public void BonusClick()
    {
        Score += Click;
        Check();
    }

    public void Bonus()
    {
        Click += Score;
        Score = 0;
        Check();
    }
}
