using System.Collections.Generic;
using System;
using System.Threading.Tasks;

using DataApiService;
using DataApiService.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using WebServer.Models;
using Microsoft.Extensions.DependencyModel.Resolution;

namespace WebServer.Controllers
{
    public class CommandsController : BaseController
    {

        private readonly ILogger<EventsController> _logger;
        private IDataManager _dataManager;
        public CommandsController(ILogger<EventsController> logger, IDataManager dataManager)
        {
            this._logger = logger;
            this._dataManager = dataManager;
            _dataManager.Auth("user2", "password2");
        }

        public async Task<IActionResult> Index()
        {
            //Заполняем дроп лист выбора автоматов
            await SetCommandsDropList();
            return View(new List<CommandsJournal>());
        }
        [HttpPost]
        public async Task<IActionResult> Index(CommandActionParameters pars)
        {
            //Проверка параметров запроса
            if (!ModelState.IsValid)
            {
                //Можно формировать сообщение или отправить на страницу ошибок, пока так
                //TODO Не в продакшен
                return BadRequest();
            }

            //Заполняем дроп лист выбора автоматов
            await SetCommandsDropList();

            //Формируем запрос событий
            //Конвертация даты из формата ДД.ММ.ГГГГ в ГГГГ-ММ-ДД происходит при маппинге параметров в классе EventsActionParameters
            var terminalresponse =
                await _dataManager.PostItem<Request<object, object>>($"terminals/{pars.terminal_Id}/commands", pars.ToBodyString());
            if (!terminalresponse.Success)
                return BadRequest();

            var response = await _dataManager.GetItem<Request<CommandsJournal, object>>($"terminals/{pars.terminal_Id}/commands", new Dictionary<string, string>()
            {
                { "OrderByColumn", $"16" },
                { "OrderDesc", "true" }
            });
            var model = response.Items;

            return View(model);
        }

        private async Task SetCommandsDropList()
        {
            //Запрос команд
            var response = await _dataManager.GetItem<Request<Command, object>>("commands/types");
            var commands = response.Items;

            //Мапинг в дроп лист
            var resultList = commands.Select(x => new SelectListItem($"{x.Name}", x.Id.ToString())).ToList();

            //Значение для "Не выбрано"
            resultList.Insert(0, new SelectListItem(" Не выбрано ", "", true, true));
            ViewData["CommandsRaw"] = commands;
            ViewData["Commands"] = resultList;
        }
    }
}
