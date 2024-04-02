using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace Gleggmire_Discord_Bot.commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command("test")]
        public async Task MyFirstCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Hallo {ctx.User.Username}");
        }

        [Command("rick")]
        public async Task Rick(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media1.tenor.com/m/x8v1oNUOmg4AAAAd/rickroll-roll.gif");
        }

        [Command("add")]
        public async Task Add(CommandContext ctx, int number1, int number2) 
        {
            int result = number1 + number2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }

        [Command("subtract")]
        public async Task Subtract(CommandContext ctx, int number1, int number2)
        {
            int result = number1 - number2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }

        [Command("gleggmire")]
        public async Task GleggYT(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Hallo schmieriger {ctx.User.Username}.  Das hier ist mein neustes Youtube Video. Hahaha Koooompleterino jo jo jo   " +
                $"https://www.youtube.com/@gleggmire/videos");
        }

        [Command("beispiel")]
        public async Task Beispiel(CommandContext ctx)
        {

            if (ctx.Message.Author.Username == "vsunnn")
            {
                await ctx.Message.DeleteAsync("Grund für die Löschung"); 
            }
            else
            {
                await ctx.RespondAsync($"Hallo {ctx.User.Username}. " +
                    $"Dieser Befehl kann nur von ***balls*** verwendet werden."); //"balls" ist der Server-Owner
            }
        }

    }
}
