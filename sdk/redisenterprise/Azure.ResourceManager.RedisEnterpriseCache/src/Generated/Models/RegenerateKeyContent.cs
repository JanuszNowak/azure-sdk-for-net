// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    /// <summary> Specifies which access keys to reset to a new random value. </summary>
    public partial class RegenerateKeyContent
    {
        /// <summary> Initializes a new instance of RegenerateKeyContent. </summary>
        /// <param name="keyType"> Which access key to regenerate. </param>
        public RegenerateKeyContent(AccessKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Which access key to regenerate. </summary>
        public AccessKeyType KeyType { get; }
    }
}
