﻿using OrchardVNext.Environment.Configuration;
using System;

namespace OrchardVNext.Environment {
    public interface IOrchardShellHost {
        void BeginRequest(ShellSettings shellSettings);
        void EndRequest(ShellSettings shellSettings);
    }

    public class DefaultOrchardShellHost : IOrchardShellHost {
        public DefaultOrchardShellHost() {
        }

        void IOrchardShellHost.BeginRequest(ShellSettings settings) {
            Console.WriteLine("Begin Request for tenant {0}", settings.Name);
        }

        void IOrchardShellHost.EndRequest(ShellSettings settings) {
            Console.WriteLine("End Request for tenant {0}", settings.Name);
        }
    }
}