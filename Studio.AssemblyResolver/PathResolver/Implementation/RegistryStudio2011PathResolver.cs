﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Studio.AssemblyResolver.PathResolver.Implementation
{
    internal class RegistryStudio2011PathResolver : AbstractRegistryPathResolver
    {
        public override string GetStudioVersion()
        {
            return "Studio2";
        }
    }
}
