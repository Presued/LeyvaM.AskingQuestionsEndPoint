//Manuel L.
//10-25-22
//Asking Questions EndPoint
//The user will be asked two questions, and the user will have to input two answers
//Peer Review: Chris Martinez, I typed in my name and the time, and the url was able to populate the name and time. Works great.

using Microsoft.AspNetCore.Mvc;

namespace LeyvaM.AskingQuestionsEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh3/{name}/{time}")]

    public string AskingQuestions(string name, int time)
    {
        return $"your name is {name} & you woke up at {time}";
    }
}
