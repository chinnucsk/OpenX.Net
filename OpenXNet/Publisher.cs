﻿#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class Publisher {
        [XmlRpcMember("publisherId")]
        public int Id { get; set; }

        [XmlRpcMember("publisherName")]
        public string PublisherName { get; set; }

        [XmlRpcMember("website")]
        public string Website { get; set; }

        [XmlRpcMember("emailAddress")]
        public string EmailAddress { get; set; }

        [XmlRpcMember("contactName")]
        public string ContactName { get; set; }

        [XmlRpcMember("comments")]
        public string Comments { get; set; }

        [XmlRpcMember("accountId")]
        public int AccountId { get; set; }

        [XmlRpcMember("agencyId")]
        public int ManagerId { get; set; }
    }
}
