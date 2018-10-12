using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WebMonitoring.Controllers
{
	public class HomeController : Controller
	{
		private const string Token = "636110092:AAGH0rsJTdfeFrg7mAzWnHfJmIOFrwxbLAA";
		private const long ChatId = -283586034;

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Test() {
			return View();
		}

		public async Task<string> Notify(int id) {
			var client = new TelegramBotClient(Token);
			var me = client.GetMeAsync().Result;
			var message = await client.SendTextMessageAsync(new ChatId(ChatId), $"You sent {id}");
			return "Ok";
		}
	}
}
