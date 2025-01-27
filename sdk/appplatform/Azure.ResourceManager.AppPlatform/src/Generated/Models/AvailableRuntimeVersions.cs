// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The AvailableRuntimeVersions. </summary>
    internal partial class AvailableRuntimeVersions
    {
        /// <summary> Initializes a new instance of AvailableRuntimeVersions. </summary>
        internal AvailableRuntimeVersions()
        {
            Value = new ChangeTrackingList<AppPlatformSupportedRuntimeVersion>();
        }

        /// <summary> Initializes a new instance of AvailableRuntimeVersions. </summary>
        /// <param name="value"> A list of all supported runtime versions. </param>
        internal AvailableRuntimeVersions(IReadOnlyList<AppPlatformSupportedRuntimeVersion> value)
        {
            Value = value;
        }

        /// <summary> A list of all supported runtime versions. </summary>
        public IReadOnlyList<AppPlatformSupportedRuntimeVersion> Value { get; }
    }
}
