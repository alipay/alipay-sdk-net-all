using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobbyOpenDeviceStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class RobbyOpenDeviceStatusQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }
    }
}
