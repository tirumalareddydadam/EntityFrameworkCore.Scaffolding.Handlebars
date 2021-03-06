﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// Modifications copyright(C) 2018 Tony Sneed.

using System;
using System.Collections.Generic;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Scaffolding.Handlebars.Tests.Fakes
{
    public class FakeDatabaseModelFactory : IDatabaseModelFactory
    {
        public virtual DatabaseModel Create(string connectionString, IEnumerable<string> tables, IEnumerable<string> schemas)
            => throw new NotImplementedException();

        public virtual DatabaseModel Create(DbConnection connectio, IEnumerable<string> tables, IEnumerable<string> schemas)
            => throw new NotImplementedException();
    }
}