using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestingAPI.Models;
using System.Diagnostics;

namespace TestingAPI.Controllers
{

    [ApiController]
    public class TestController : ControllerBase
    {
        //Create/Edit
        [HttpPost]
        [Route("api/new")]
        public JsonResult NewGame(NewGameRequest test)
        {
            ErrorResponse error;
            if (test.Width < 2 || test.Width > 30 || test.Height < 2 || test.Height > 30)
            {
                error = new();
                error.Error = "ширина поля должна быть не менее 2 и не более 30";
                return new JsonResult(error);
            }
            else if (test.Mines_count < 1 || test.Mines_count > test.Height * test.Width)
            {
                error = new();
                error.Error = $"количество мин должно быть не менее 1 и строго менее количества ячеек {test.Width * test.Height}";
                return new JsonResult(error);
            }
            GameInfoResponse gameInfo = new()
            {
                Game_id = Guid.NewGuid().ToString(),
                Width = test.Width,
                Height = test.Height,
                Mines_count = test.Mines_count,
                Completed = false,
            };
            gameInfo.Field = new string[test.Width][];
            for (int i = 0; i < test.Width; i++)
            {
                gameInfo.Field[i] = new string[test.Height];
            }
            return new JsonResult(gameInfo);
        }
        [HttpPost]
        [Route("api/turn")]
        public JsonResult Turn(GameInfoResponse test)
        {

            return new JsonResult(Ok(test));
        }

    }
}
