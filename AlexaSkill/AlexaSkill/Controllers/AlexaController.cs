using System.Web.Http;

namespace AlexaSkill.Controllers
{
    public class AlexaController : ApiController
    {
        [HttpPost, Route("api/alexa/demo")]
        public dynamic Pluralsight(dynamic request)
        {
            return new
            {
                version = "1.0",
                sessionAttributes = new { },
                response = new
                {
                    outputSpeech = new
                    {
                        type = "PlainText",
                        text = "Hello world"
                    },
                    card = new
                    {
                        type = "Simple",
                        title = "Pluralsight",
                        content = "Hello\n cruel world!"
                    },
                    shouldEndSession = true
                }
            };
        }
    }
}
