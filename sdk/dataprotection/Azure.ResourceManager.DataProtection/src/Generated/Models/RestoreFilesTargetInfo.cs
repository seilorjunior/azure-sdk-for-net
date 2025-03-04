// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtection.Models
{
    /// <summary> Class encapsulating restore as files target parameters. </summary>
    public partial class RestoreFilesTargetInfo : RestoreTargetInfoBase
    {
        /// <summary> Initializes a new instance of RestoreFilesTargetInfo. </summary>
        /// <param name="recoveryOption"> Recovery Option. </param>
        /// <param name="targetDetails"> Destination of RestoreAsFiles operation, when destination is not a datasource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetDetails"/> is null. </exception>
        public RestoreFilesTargetInfo(RecoveryOption recoveryOption, TargetDetails targetDetails) : base(recoveryOption)
        {
            if (targetDetails == null)
            {
                throw new ArgumentNullException(nameof(targetDetails));
            }

            TargetDetails = targetDetails;
            ObjectType = "RestoreFilesTargetInfo";
        }

        /// <summary> Destination of RestoreAsFiles operation, when destination is not a datasource. </summary>
        public TargetDetails TargetDetails { get; }
    }
}
