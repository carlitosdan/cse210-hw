using System;
public class prompt(){
    public List<string> _question = new List<string>();

    public static int getRandomQuestion(int questionsCount){
        if(questionsCount < 0)
            {throw new Exception("The list of questions is empty");}

        Random rnd = new Random();
        int indexQuestion = rnd.Next(0, questionsCount); 
        return indexQuestion;
    }

}
        