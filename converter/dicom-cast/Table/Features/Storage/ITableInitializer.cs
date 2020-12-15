﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;

namespace Microsoft.Health.DicomCast.TableStorage.Features.Storage
{
    public interface ITableInitializer
    {
        Task<CloudTableClient> InitializeTableAsync(CloudTableClient client);
    }
}