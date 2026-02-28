using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterMaterialCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterMaterialCreateModel : AopObject
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
        /// 活动解决方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
