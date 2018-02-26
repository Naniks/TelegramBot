using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using TelegramBotApp.Models;
using TelegramBotApp.Models.Commands;

namespace TelegramBotApp.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")]  //web hook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }

            HelloCommand commandEx = new HelloCommand();
            commandEx.Execute(message, client);


            return Ok();
        }
    }
}
