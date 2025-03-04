// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtection.Models
{
    /// <summary>
    /// Azure backup recoveryPoint based restore request
    /// Please note <see cref="AzureBackupRecoveryPointBasedRestoreRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureBackupRestoreWithRehydrationRequest"/>.
    /// </summary>
    public partial class AzureBackupRecoveryPointBasedRestoreRequest : AzureBackupRestoreContent
    {
        /// <summary> Initializes a new instance of AzureBackupRecoveryPointBasedRestoreRequest. </summary>
        /// <param name="restoreTargetInfo">
        /// Gets or sets the restore target information.
        /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="RestoreTargetInfo"/>.
        /// </param>
        /// <param name="sourceDataStoreType"> Gets or sets the type of the source data store. </param>
        /// <param name="recoveryPointId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="restoreTargetInfo"/> or <paramref name="recoveryPointId"/> is null. </exception>
        public AzureBackupRecoveryPointBasedRestoreRequest(RestoreTargetInfoBase restoreTargetInfo, SourceDataStoreType sourceDataStoreType, string recoveryPointId) : base(restoreTargetInfo, sourceDataStoreType)
        {
            if (restoreTargetInfo == null)
            {
                throw new ArgumentNullException(nameof(restoreTargetInfo));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }

            RecoveryPointId = recoveryPointId;
            ObjectType = "AzureBackupRecoveryPointBasedRestoreRequest";
        }

        /// <summary> Gets the recovery point id. </summary>
        public string RecoveryPointId { get; }
    }
}
