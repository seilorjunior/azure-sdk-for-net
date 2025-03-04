// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The state of the cluster provisioning. </summary>
    public readonly partial struct AvsPrivateCloudClusterProvisioningState : IEquatable<AvsPrivateCloudClusterProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudClusterProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvsPrivateCloudClusterProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";

        /// <summary> Succeeded. </summary>
        public static AvsPrivateCloudClusterProvisioningState Succeeded { get; } = new AvsPrivateCloudClusterProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AvsPrivateCloudClusterProvisioningState Failed { get; } = new AvsPrivateCloudClusterProvisioningState(FailedValue);
        /// <summary> Cancelled. </summary>
        public static AvsPrivateCloudClusterProvisioningState Cancelled { get; } = new AvsPrivateCloudClusterProvisioningState(CancelledValue);
        /// <summary> Deleting. </summary>
        public static AvsPrivateCloudClusterProvisioningState Deleting { get; } = new AvsPrivateCloudClusterProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static AvsPrivateCloudClusterProvisioningState Updating { get; } = new AvsPrivateCloudClusterProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="AvsPrivateCloudClusterProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AvsPrivateCloudClusterProvisioningState left, AvsPrivateCloudClusterProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvsPrivateCloudClusterProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AvsPrivateCloudClusterProvisioningState left, AvsPrivateCloudClusterProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvsPrivateCloudClusterProvisioningState"/>. </summary>
        public static implicit operator AvsPrivateCloudClusterProvisioningState(string value) => new AvsPrivateCloudClusterProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvsPrivateCloudClusterProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvsPrivateCloudClusterProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
