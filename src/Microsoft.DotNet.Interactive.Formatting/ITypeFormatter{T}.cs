﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.Formatting;

public interface ITypeFormatter<in T> : ITypeFormatter
{
    bool Format(T instance, FormatContext context);
}