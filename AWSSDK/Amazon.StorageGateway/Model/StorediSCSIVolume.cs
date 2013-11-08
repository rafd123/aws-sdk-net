/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>Storedi S C S I Volume
    /// </summary>
    public partial class StorediSCSIVolume
    {
        
        private string volumeARN;
        private string volumeId;
        private string volumeType;
        private string volumeStatus;
        private long? volumeSizeInBytes;
        private double? volumeProgress;
        private string volumeDiskId;
        private string sourceSnapshotId;
        private bool? preservedExistingData;
        private VolumeiSCSIAttributes volumeiSCSIAttributes;
        public string VolumeARN
        {
            get { return this.volumeARN; }
            set { this.volumeARN = value; }
        }

        /// <summary>
        /// Sets the VolumeARN property
        /// </summary>
        /// <param name="volumeARN">The value to set for the VolumeARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeARN(string volumeARN)
        {
            this.volumeARN = volumeARN;
            return this;
        }
            

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;
        }
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        /// <summary>
        /// Sets the VolumeId property
        /// </summary>
        /// <param name="volumeId">The value to set for the VolumeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeId(string volumeId)
        {
            this.volumeId = volumeId;
            return this;
        }
            

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }
        public string VolumeType
        {
            get { return this.volumeType; }
            set { this.volumeType = value; }
        }

        /// <summary>
        /// Sets the VolumeType property
        /// </summary>
        /// <param name="volumeType">The value to set for the VolumeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeType(string volumeType)
        {
            this.volumeType = volumeType;
            return this;
        }
            

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this.volumeType != null;
        }
        public string VolumeStatus
        {
            get { return this.volumeStatus; }
            set { this.volumeStatus = value; }
        }

        /// <summary>
        /// Sets the VolumeStatus property
        /// </summary>
        /// <param name="volumeStatus">The value to set for the VolumeStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeStatus(string volumeStatus)
        {
            this.volumeStatus = volumeStatus;
            return this;
        }
            

        // Check to see if VolumeStatus property is set
        internal bool IsSetVolumeStatus()
        {
            return this.volumeStatus != null;
        }
        public long VolumeSizeInBytes
        {
            get { return this.volumeSizeInBytes ?? default(long); }
            set { this.volumeSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the VolumeSizeInBytes property
        /// </summary>
        /// <param name="volumeSizeInBytes">The value to set for the VolumeSizeInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeSizeInBytes(long volumeSizeInBytes)
        {
            this.volumeSizeInBytes = volumeSizeInBytes;
            return this;
        }
            

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this.volumeSizeInBytes.HasValue;
        }
        public double VolumeProgress
        {
            get { return this.volumeProgress ?? default(double); }
            set { this.volumeProgress = value; }
        }

        /// <summary>
        /// Sets the VolumeProgress property
        /// </summary>
        /// <param name="volumeProgress">The value to set for the VolumeProgress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeProgress(double volumeProgress)
        {
            this.volumeProgress = volumeProgress;
            return this;
        }
            

        // Check to see if VolumeProgress property is set
        internal bool IsSetVolumeProgress()
        {
            return this.volumeProgress.HasValue;
        }
        public string VolumeDiskId
        {
            get { return this.volumeDiskId; }
            set { this.volumeDiskId = value; }
        }

        /// <summary>
        /// Sets the VolumeDiskId property
        /// </summary>
        /// <param name="volumeDiskId">The value to set for the VolumeDiskId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeDiskId(string volumeDiskId)
        {
            this.volumeDiskId = volumeDiskId;
            return this;
        }
            

        // Check to see if VolumeDiskId property is set
        internal bool IsSetVolumeDiskId()
        {
            return this.volumeDiskId != null;
        }
        public string SourceSnapshotId
        {
            get { return this.sourceSnapshotId; }
            set { this.sourceSnapshotId = value; }
        }

        /// <summary>
        /// Sets the SourceSnapshotId property
        /// </summary>
        /// <param name="sourceSnapshotId">The value to set for the SourceSnapshotId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithSourceSnapshotId(string sourceSnapshotId)
        {
            this.sourceSnapshotId = sourceSnapshotId;
            return this;
        }
            

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this.sourceSnapshotId != null;
        }
        public bool PreservedExistingData
        {
            get { return this.preservedExistingData ?? default(bool); }
            set { this.preservedExistingData = value; }
        }

        /// <summary>
        /// Sets the PreservedExistingData property
        /// </summary>
        /// <param name="preservedExistingData">The value to set for the PreservedExistingData property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithPreservedExistingData(bool preservedExistingData)
        {
            this.preservedExistingData = preservedExistingData;
            return this;
        }
            

        // Check to see if PreservedExistingData property is set
        internal bool IsSetPreservedExistingData()
        {
            return this.preservedExistingData.HasValue;
        }

        /// <summary>
        /// Lists iSCSI information about a volume.
        ///  
        /// </summary>
        public VolumeiSCSIAttributes VolumeiSCSIAttributes
        {
            get { return this.volumeiSCSIAttributes; }
            set { this.volumeiSCSIAttributes = value; }
        }

        /// <summary>
        /// Sets the VolumeiSCSIAttributes property
        /// </summary>
        /// <param name="volumeiSCSIAttributes">The value to set for the VolumeiSCSIAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StorediSCSIVolume WithVolumeiSCSIAttributes(VolumeiSCSIAttributes volumeiSCSIAttributes)
        {
            this.volumeiSCSIAttributes = volumeiSCSIAttributes;
            return this;
        }
            

        // Check to see if VolumeiSCSIAttributes property is set
        internal bool IsSetVolumeiSCSIAttributes()
        {
            return this.volumeiSCSIAttributes != null;
        }
    }
}
