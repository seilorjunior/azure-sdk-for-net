// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtection.Models
{
    /// <summary> Validate for backup request. </summary>
    public partial class ValidateForBackupContent
    {
        /// <summary> Initializes a new instance of ValidateForBackupContent. </summary>
        /// <param name="backupInstance"> Backup Instance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupInstance"/> is null. </exception>
        public ValidateForBackupContent(BackupInstance backupInstance)
        {
            if (backupInstance == null)
            {
                throw new ArgumentNullException(nameof(backupInstance));
            }

            BackupInstance = backupInstance;
        }

        /// <summary> Backup Instance. </summary>
        public BackupInstance BackupInstance { get; }
    }
}
