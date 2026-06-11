using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntLinkeQueryreimbursequotaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntLinkeQueryreimbursequotaQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("months")]
        [XmlArrayItem("string")]
        public List<string> Months { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
