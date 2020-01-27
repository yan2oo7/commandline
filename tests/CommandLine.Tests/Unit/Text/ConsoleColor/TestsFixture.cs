﻿using System;
using CommandLine.Text;
using CommandLine.Text.ConsoleColor;

namespace CommandLine.Tests
{
    public class TestsFixture : IDisposable
    {
        public TestsFixture()
        {
            // Do "global" initialization here; Only called once.
        }

        public void Dispose()
        {
            // Do "global" teardown here; Only called once.
            //Reset static StyleType
            StyleBuilder.StyleType = StyleType.None;
        }
    }
}
