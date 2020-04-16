﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.LanguageService
{
    public class Range
    {
        public Position Start { get; }
        public Position End { get; }

        public Range(Position start, Position end)
        {
            Start = start;
            End = end;
        }
    }
}
