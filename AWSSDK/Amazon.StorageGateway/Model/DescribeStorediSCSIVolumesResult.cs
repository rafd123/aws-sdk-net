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
    /// <summary>Describe Storedi S C S I Volumes Result
    /// </summary>
    public partial class DescribeStorediSCSIVolumesResult
    {
        
        private List<StorediSCSIVolume> storediSCSIVolumes = new List<StorediSCSIVolume>();
        public List<StorediSCSIVolume> StorediSCSIVolumes
        {
            get { return this.storediSCSIVolumes; }
            set { this.storediSCSIVolumes = value; }
        }
        /// <summary>
        /// Adds elements to the StorediSCSIVolumes collection
        /// </summary>
        /// <param name="storediSCSIVolumes">The values to add to the StorediSCSIVolumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStorediSCSIVolumesResult WithStorediSCSIVolumes(params StorediSCSIVolume[] storediSCSIVolumes)
        {
            foreach (StorediSCSIVolume element in storediSCSIVolumes)
            {
                this.storediSCSIVolumes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the StorediSCSIVolumes collection
        /// </summary>
        /// <param name="storediSCSIVolumes">The values to add to the StorediSCSIVolumes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStorediSCSIVolumesResult WithStorediSCSIVolumes(IEnumerable<StorediSCSIVolume> storediSCSIVolumes)
        {
            foreach (StorediSCSIVolume element in storediSCSIVolumes)
            {
                this.storediSCSIVolumes.Add(element);
            }

            return this;
        }

        // Check to see if StorediSCSIVolumes property is set
        internal bool IsSetStorediSCSIVolumes()
        {
            return this.storediSCSIVolumes.Count > 0;
        }
    }
}
