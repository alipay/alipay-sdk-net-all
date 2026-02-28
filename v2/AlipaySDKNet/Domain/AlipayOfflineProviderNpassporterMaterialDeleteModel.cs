using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterMaterialDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterMaterialDeleteModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("coil_no_list")]
        [XmlArrayItem("string")]
        public List<string> CoilNoList { get; set; }

        /// <summary>
        /// 方案配置code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
