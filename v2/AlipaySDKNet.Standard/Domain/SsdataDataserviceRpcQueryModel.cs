using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataDataserviceRpcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRpcQueryModel : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("user")]
        [XmlArrayItem("string")]
        public List<string> User { get; set; }
    }
}
