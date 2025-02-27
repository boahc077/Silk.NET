// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RESOURCE_HEAP_TIER")]
    public enum ResourceHeapTier : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Tier1\"")]
        [NativeName("Name", "D3D12_RESOURCE_HEAP_TIER_1")]
        ResourceHeapTier1 = 0x1,
        [Obsolete("Deprecated in favour of \"Tier2\"")]
        [NativeName("Name", "D3D12_RESOURCE_HEAP_TIER_2")]
        ResourceHeapTier2 = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_HEAP_TIER_1")]
        Tier1 = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_HEAP_TIER_2")]
        Tier2 = 0x2,
    }
}
