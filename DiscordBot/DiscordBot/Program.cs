using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;

        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();

            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            String token = "NjM2NDUwODUyNTYyOTI3NjE2.XbNh1w.c7X6h2BTlFxezYfgXqJxyS0vFlM";

            _client.Log += _client_Log;

            await RegisterCommandsAsync();
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task _client_Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        public async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);

        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_client, message);
            if (message.Author.IsBot) return;

            int argPos = 0;
            if(message.HasStringPrefix("!",ref argPos))
            {
                var result = await _commands.ExecuteAsync(context, argPos, _services);
                if (!result.IsSuccess) Console.WriteLine(result.Error);
            }
            
            if(message.Content.ToLower().Contains("daddy"))
            {
                await message.DeleteAsync();

                await context.Channel.SendFileAsync("C:/Users/Colin/Desktop/DiscordBot/GrahamDiscordBot/DiscordBot/Stop.gif", message.Author.Mention + " don't say '" + message + "'", false, null);

            }

            if (message.Content.ToLower().Contains("hello graham") || message.Content.ToLower().Contains("hi graham") || message.Content.ToLower().Contains("heyo graham"))
            {
                await context.Channel.SendMessageAsync("Heyo " + message.Author.Mention);
            }

        }
    }
}
