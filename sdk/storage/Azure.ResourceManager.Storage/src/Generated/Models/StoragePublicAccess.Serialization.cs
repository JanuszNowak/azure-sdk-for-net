// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static partial class StoragePublicAccessExtensions
    {
        public static string ToSerialString(this StoragePublicAccess value) => value switch
        {
            StoragePublicAccess.None => "None",
            StoragePublicAccess.Container => "Container",
            StoragePublicAccess.Blob => "Blob",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StoragePublicAccess value.")
        };

        public static StoragePublicAccess ToStoragePublicAccess(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return StoragePublicAccess.None;
            if (string.Equals(value, "Container", StringComparison.InvariantCultureIgnoreCase)) return StoragePublicAccess.Container;
            if (string.Equals(value, "Blob", StringComparison.InvariantCultureIgnoreCase)) return StoragePublicAccess.Blob;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StoragePublicAccess value.");
        }
    }
}
