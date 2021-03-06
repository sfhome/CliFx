﻿using Cocona;

namespace CliFx.Benchmarks.Commands
{
    public class CoconaCommand
    {
        public void Execute(
            [Option("str", new []{'s'})]
            string? strOption,
            [Option("int", new []{'i'})]
            int intOption,
            [Option("bool", new []{'b'})]
            bool boolOption)
        {
        }
    }
}