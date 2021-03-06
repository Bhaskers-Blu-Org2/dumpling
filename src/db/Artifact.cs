﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dumpling.db
{
    [DataContract]
    public class Artifact
    {
        public Artifact()
        {
            Indexes = new HashSet<ArtifactIndex>();
        }

        [Key]
        [StringLength(40)]
        [DataMember]
        public string Hash { get; set; }

        [StringLength(64)]
        [DataMember]
        public string Uuid { get; set; }

        [DataMember]
        public string FileName { get; set; }
        
        public string Url { get; set; }

        [Required]
        [DataMember]
        [StringLength(32)]
        public string Format { get; set; }

        [DataMember]
        public long Size { get; set; }

        [DataMember]
        public long CompressedSize { get; set; }

        [DataMember]
        public DateTime UploadTime { get; set; }

        public virtual ICollection<ArtifactIndex> Indexes { get; set; }
    }
}
