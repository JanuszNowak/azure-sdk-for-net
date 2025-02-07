// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The replication mode of a distributed availability group. Parameter will be ignored during link creation. </summary>
    public readonly partial struct ReplicationMode : IEquatable<ReplicationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReplicationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReplicationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AsyncValue = "Async";
        private const string SyncValue = "Sync";

        /// <summary> Async. </summary>
        public static ReplicationMode Async { get; } = new ReplicationMode(AsyncValue);
        /// <summary> Sync. </summary>
        public static ReplicationMode Sync { get; } = new ReplicationMode(SyncValue);
        /// <summary> Determines if two <see cref="ReplicationMode"/> values are the same. </summary>
        public static bool operator ==(ReplicationMode left, ReplicationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicationMode"/> values are not the same. </summary>
        public static bool operator !=(ReplicationMode left, ReplicationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicationMode"/>. </summary>
        public static implicit operator ReplicationMode(string value) => new ReplicationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
