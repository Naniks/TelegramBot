using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotApp.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotappnvk.azurewebsites.net/";   //ref to bot

        //public static string Name { get; set; } = "Nivk_bot";  //name of contact

        public static string Key { get; set; } = "340903975:AAHeQ2yYJ-p3tg9dhOE-zesKBTZrSJJ2QGc"; //API key of bot
    }
}