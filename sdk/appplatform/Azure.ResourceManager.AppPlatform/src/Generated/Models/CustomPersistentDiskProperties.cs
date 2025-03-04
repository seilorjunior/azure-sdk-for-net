// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary>
    /// Custom persistent disk resource payload.
    /// Please note <see cref="CustomPersistentDiskProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureFileVolume"/>.
    /// </summary>
    public abstract partial class CustomPersistentDiskProperties
    {
        /// <summary> Initializes a new instance of CustomPersistentDiskProperties. </summary>
        /// <param name="mountPath"> The mount path of the persistent disk. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mountPath"/> is null. </exception>
        protected CustomPersistentDiskProperties(string mountPath)
        {
            if (mountPath == null)
            {
                throw new ArgumentNullException(nameof(mountPath));
            }

            MountPath = mountPath;
            MountOptions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CustomPersistentDiskProperties. </summary>
        /// <param name="underlyingResourceType"> The type of the underlying resource to mount as a persistent disk. </param>
        /// <param name="mountPath"> The mount path of the persistent disk. </param>
        /// <param name="readOnly"> Indicates whether the persistent disk is a readOnly one. </param>
        /// <param name="mountOptions"> These are the mount options for a persistent disk. </param>
        internal CustomPersistentDiskProperties(UnderlyingResourceType underlyingResourceType, string mountPath, bool? readOnly, IList<string> mountOptions)
        {
            UnderlyingResourceType = underlyingResourceType;
            MountPath = mountPath;
            ReadOnly = readOnly;
            MountOptions = mountOptions;
        }

        /// <summary> The type of the underlying resource to mount as a persistent disk. </summary>
        internal UnderlyingResourceType UnderlyingResourceType { get; set; }
        /// <summary> The mount path of the persistent disk. </summary>
        public string MountPath { get; set; }
        /// <summary> Indicates whether the persistent disk is a readOnly one. </summary>
        public bool? ReadOnly { get; set; }
        /// <summary> These are the mount options for a persistent disk. </summary>
        public IList<string> MountOptions { get; }
    }
}
