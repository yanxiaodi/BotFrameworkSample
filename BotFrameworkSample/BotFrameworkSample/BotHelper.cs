using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BotFrameworkSample
{
    public static class BotHelper
    {
        public static async Task SendResponse(string input, IDialogContext context)
        {
            if (input.ToLower().Contains("hi"))
            {
                await context.PostAsync($"Please input your package traker number.");
            }
            else if (input == "EMS1234567890")
            {
                await context.PostAsync($"Your package is still in auditing process. Please wait a moment and recheck later.");
            }
            else if (input == "EMS1234567891")
            {
                await context.PostAsync($"You have paid the tariff for your package. Please contact your shipper company.");
            }
            else if (input.StartsWith("EMS") && input.Length == 13)
            {
                await context.PostAsync($"You need to pay the tariff for your package: RMB150. Please choose your payment system: 1. Wechat Pay; 2. Alipay; 3. Later");
            }
            else if (input == "1")
            {
                await context.PostAsync($"You paid the tariff by Wechat Pay. Thanks for your collaboration! Please contact your shipper company to get your package.");
            }
            else if (input == "2")
            {
                await context.PostAsync($"You paid the tariff by Alipay. Thanks for your collaboration! Please contact your shipper company to get your package.");
            }
            else if (input == "3")
            {
                await context.PostAsync($"Thanks! You can pay the tariff later.");
            }
            else
            {
                await context.PostAsync($"I do not what you are saying. Please input your tracker number.");
            }
        }
    }
}