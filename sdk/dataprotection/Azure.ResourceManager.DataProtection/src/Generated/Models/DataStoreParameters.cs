// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtection.Models
{
    /// <summary>
    /// Parameters for DataStore
    /// Please note <see cref="DataStoreParameters"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureOperationalStoreParameters"/>.
    /// </summary>
    public abstract partial class DataStoreParameters
    {
        /// <summary> Initializes a new instance of DataStoreParameters. </summary>
        /// <param name="dataStoreType"> type of datastore; Operational/Vault/Archive. </param>
        protected DataStoreParameters(DataStoreType dataStoreType)
        {
            DataStoreType = dataStoreType;
        }

        /// <summary> Initializes a new instance of DataStoreParameters. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="dataStoreType"> type of datastore; Operational/Vault/Archive. </param>
        internal DataStoreParameters(string objectType, DataStoreType dataStoreType)
        {
            ObjectType = objectType;
            DataStoreType = dataStoreType;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
        /// <summary> type of datastore; Operational/Vault/Archive. </summary>
        public DataStoreType DataStoreType { get; set; }
    }
}
