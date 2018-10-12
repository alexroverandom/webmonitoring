using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WebMonitoring.Controllers
{
	public class HomeController : Controller
	{
		private const long BotId = 159027523;
		private const long Koef = 4;
		private const string Token = "AAGH0rsJTdfeFrg7mAzWnHfJmIOFrwxbLAA";
		private const long ChatId = -283586034;

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Test() {
			return View();
		}

		public async Task<string> Notify(int id) {
			var client = new TelegramBotClient($"{BotId*Koef}:{Token}");
			var me = client.GetMeAsync().Result;
			var message = await client.SendTextMessageAsync(new ChatId(ChatId), $"You sent {id}");
			return "Ok";
		}
	}
}
