﻿#region Copyright Notice
/*
Copyright © Microsoft Open Technologies, Inc.
All Rights Reserved
Apache 2.0 License

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace DeployCmdlets4WA.ServiceProxy
{
    [DataContract(Name = "InputEndpoint", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class InputEndpoint
    {
        [DataMember(Order = 1)]
        public int Port { get; set; }

        [DataMember(Order = 2)]
        public string Protocol { get; set; }

        [DataMember(Order = 3)]
        public string Vip { get; set; }
    }
}
