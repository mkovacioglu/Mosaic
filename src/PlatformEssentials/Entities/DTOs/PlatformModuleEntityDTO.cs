/* Copyright 2017 Cimpress

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License. */


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VP.FF.PT.Common.PlatformEssentials.Entities.DTOs
{
    [DataContract]
    public class PlatformModuleEntityDTO
    {
        [DataMember]
        public Int64 Id { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public Int32 LimitItemCount { get; set; }

        [DataMember]
        public List<PlatformItemDTO> PlatformItems { get; set; }

        public PlatformModuleEntityDTO()
        {
        }

        public PlatformModuleEntityDTO(Int64 id, String name, Int32 limitItemCount, List<PlatformItemDTO> platformItems)
        {
			Id = id;
			Name = name;
			LimitItemCount = limitItemCount;
			PlatformItems = platformItems;
        }
    }
}