// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Action when client IP address is matched. </summary>
    public readonly partial struct IPRuleAction : IEquatable<IPRuleAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IPRuleAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPRuleAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";

        /// <summary> Allow. </summary>
        public static IPRuleAction Allow { get; } = new IPRuleAction(AllowValue);
        /// <summary> Determines if two <see cref="IPRuleAction"/> values are the same. </summary>
        public static bool operator ==(IPRuleAction left, IPRuleAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPRuleAction"/> values are not the same. </summary>
        public static bool operator !=(IPRuleAction left, IPRuleAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IPRuleAction"/>. </summary>
        public static implicit operator IPRuleAction(string value) => new IPRuleAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPRuleAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPRuleAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
