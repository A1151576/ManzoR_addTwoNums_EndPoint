/*
                        Rafael Manzo
                Add two numbers end point 
                10/25/2022
// Peer Review: Christopher Prado 25OCT22 The code runs effectively & is organized properly as an API input hosted locally through the postman.*/

using Microsoft.AspNetCore.Mvc;

namespace ManzoR_addTwoNums_EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AdditionController : ControllerBase
{
    [HttpGet]
    [Route("Adding/{number1}/{number2}")]

    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }
}

