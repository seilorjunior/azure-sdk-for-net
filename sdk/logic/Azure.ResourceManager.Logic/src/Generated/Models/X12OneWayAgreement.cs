// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 one-way agreement. </summary>
    public partial class X12OneWayAgreement
    {
        /// <summary> Initializes a new instance of X12OneWayAgreement. </summary>
        /// <param name="senderBusinessIdentity"> The sender business identity. </param>
        /// <param name="receiverBusinessIdentity"> The receiver business identity. </param>
        /// <param name="protocolSettings"> The X12 protocol settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="senderBusinessIdentity"/>, <paramref name="receiverBusinessIdentity"/> or <paramref name="protocolSettings"/> is null. </exception>
        public X12OneWayAgreement(IntegrationAccountBusinessIdentity senderBusinessIdentity, IntegrationAccountBusinessIdentity receiverBusinessIdentity, X12ProtocolSettings protocolSettings)
        {
            if (senderBusinessIdentity == null)
            {
                throw new ArgumentNullException(nameof(senderBusinessIdentity));
            }
            if (receiverBusinessIdentity == null)
            {
                throw new ArgumentNullException(nameof(receiverBusinessIdentity));
            }
            if (protocolSettings == null)
            {
                throw new ArgumentNullException(nameof(protocolSettings));
            }

            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
        }

        /// <summary> The sender business identity. </summary>
        public IntegrationAccountBusinessIdentity SenderBusinessIdentity { get; set; }
        /// <summary> The receiver business identity. </summary>
        public IntegrationAccountBusinessIdentity ReceiverBusinessIdentity { get; set; }
        /// <summary> The X12 protocol settings. </summary>
        public X12ProtocolSettings ProtocolSettings { get; set; }
    }
}
