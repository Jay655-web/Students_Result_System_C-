static void CalculateResults(Students s)
{
    int total = 0;
    for(int i = 0; i < s.Scores.Length; i++)
    {
        total += s.Scores[i];
    }

    s.TotalScore = total;
    s.AverageScore = (double)total / s.Scores.Length;

    if(s.AverageScore >= 80)
    {
        s.Grade = "A";
    }
    else if(s.AverageScore >= 70)
    {
        s.Grade = "B";
    }
    else if(s.AverageScore >= 60)
    {
        s.Grade = "C";
    }
    else if(s.AverageScore >= 50)
    {
        s.Grade = "D";
    }
    else
    {
        s.Grade = "F";
    }

    s.Status = (s.AverageScore >= 50) ? "Passed" : "Failed";
}