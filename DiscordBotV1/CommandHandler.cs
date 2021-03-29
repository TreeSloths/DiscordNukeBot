using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DiscordBotV1
{
    public class Commandhandler
    {
        private readonly DiscordSocketClient _client;
        private readonly CommandService _commands;
        private IServiceProvider _serviceProvider;
        private readonly Microsoft.Extensions.Logging.ILogger _Ilogger;

        public Commandhandler(DiscordSocketClient client, CommandService commands)
        {
            _commands = commands;
            _client = client;
        }

        public async Task InstallCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(assembly: Assembly.GetEntryAssembly(), services: _serviceProvider);
        }

        private async Task HandleCommandAsync(SocketMessage messageParam)
        {
            var message = messageParam as SocketUserMessage;
            if (message == null) return;
            int argPos = 0;

            if (!(message.HasCharPrefix('!', ref argPos)) || message.Author.IsBot) return;

            var context = new SocketCommandContext(_client, message);
            await _commands.ExecuteAsync(context: context, argPos: argPos, services: _serviceProvider);
        }

        public async Task CommandExecutedAsync(Optional<CommandInfo> command, ICommandContext context, IResult result)
        {
            if (!command.IsSpecified)
            {
                _Ilogger.LogError($"Command failed to execute for [] <-> []!");
                return;
            }


            if (result.IsSuccess)
            {
                _Ilogger.LogInformation($"Command [] executed for [] on []");
                return;
            }

            await context.Channel.SendMessageAsync($"Sorry, ... something went wrong -> ");
        }
    }
}