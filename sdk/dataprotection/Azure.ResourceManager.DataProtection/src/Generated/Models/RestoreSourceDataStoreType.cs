// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtection.Models
{
    /// <summary> Gets or sets the type of the source data store. </summary>
    public readonly partial struct RestoreSourceDataStoreType : IEquatable<RestoreSourceDataStoreType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestoreSourceDataStoreType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestoreSourceDataStoreType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OperationalStoreValue = "OperationalStore";
        private const string VaultStoreValue = "VaultStore";
        private const string ArchiveStoreValue = "ArchiveStore";

        /// <summary> OperationalStore. </summary>
        public static RestoreSourceDataStoreType OperationalStore { get; } = new RestoreSourceDataStoreType(OperationalStoreValue);
        /// <summary> VaultStore. </summary>
        public static RestoreSourceDataStoreType VaultStore { get; } = new RestoreSourceDataStoreType(VaultStoreValue);
        /// <summary> ArchiveStore. </summary>
        public static RestoreSourceDataStoreType ArchiveStore { get; } = new RestoreSourceDataStoreType(ArchiveStoreValue);
        /// <summary> Determines if two <see cref="RestoreSourceDataStoreType"/> values are the same. </summary>
        public static bool operator ==(RestoreSourceDataStoreType left, RestoreSourceDataStoreType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestoreSourceDataStoreType"/> values are not the same. </summary>
        public static bool operator !=(RestoreSourceDataStoreType left, RestoreSourceDataStoreType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RestoreSourceDataStoreType"/>. </summary>
        public static implicit operator RestoreSourceDataStoreType(string value) => new RestoreSourceDataStoreType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestoreSourceDataStoreType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestoreSourceDataStoreType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
