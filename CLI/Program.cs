// See https://aka.ms/new-console-template for more information

using OS;

var shell = ShellFactory.GetShell();

// await shell.Run("echo cunt");

var cmd = new Cmd();
var bash = new Bash();

// cmd.Run("dir");
// bash.Run("ls");
shell.Run("pwd");