using DSharpPlus;
using DSharpPlus.CommandsNext;
using Gleggmire_Discord_Bot.commands;
using Gleggmire_Discord_Bot.config;
using System.Threading.Tasks;

namespace Gleggmire_Discord_Bot
{
    internal class Program
    {
        
        private static DiscordClient Client { get; set; }
        private static CommandsNextExtension Commands { get; set; }
        static async Task Main(string[] args)
        {
            var jsonReader = new JSONReader();
            await jsonReader.ReadJSON();

            var discordconfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All, 
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            Client = new DiscordClient(discordconfig);

            Client.Ready += Client_Ready;

            var commandsConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { jsonReader.prefix },
                EnableMentionPrefix = true,
                EnableDms = true,
                EnableDefaultHelp = true, //Später auf false wenn selber configuert
            };

            Commands = Client.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<TestCommands>();
            
            await Client.ConnectAsync();
            await Task.Delay(-1);

        }

        private static Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args)
        {
            return Task.CompletedTask;
        }
    }
}
