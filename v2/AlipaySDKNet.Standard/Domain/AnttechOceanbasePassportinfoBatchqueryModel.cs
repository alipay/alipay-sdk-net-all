using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassportinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassportinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 通行证id列表
        /// </summary>
        [XmlArray("passport_ids")]
        [XmlArrayItem("string")]
        public List<string> PassportIds { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
