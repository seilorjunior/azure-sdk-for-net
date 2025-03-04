// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtection.Models
{
    /// <summary> Immutability state. </summary>
    public readonly partial struct ImmutabilityState : IEquatable<ImmutabilityState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImmutabilityState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImmutabilityState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string UnlockedValue = "Unlocked";
        private const string LockedValue = "Locked";

        /// <summary> Disabled. </summary>
        public static ImmutabilityState Disabled { get; } = new ImmutabilityState(DisabledValue);
        /// <summary> Unlocked. </summary>
        public static ImmutabilityState Unlocked { get; } = new ImmutabilityState(UnlockedValue);
        /// <summary> Locked. </summary>
        public static ImmutabilityState Locked { get; } = new ImmutabilityState(LockedValue);
        /// <summary> Determines if two <see cref="ImmutabilityState"/> values are the same. </summary>
        public static bool operator ==(ImmutabilityState left, ImmutabilityState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImmutabilityState"/> values are not the same. </summary>
        public static bool operator !=(ImmutabilityState left, ImmutabilityState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImmutabilityState"/>. </summary>
        public static implicit operator ImmutabilityState(string value) => new ImmutabilityState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImmutabilityState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImmutabilityState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
