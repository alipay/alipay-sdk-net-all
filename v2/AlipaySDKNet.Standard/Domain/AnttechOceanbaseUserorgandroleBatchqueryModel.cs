using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseUserorgandroleBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseUserorgandroleBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询范围的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlArray("passport_id_list")]
        [XmlArrayItem("string")]
        public List<string> PassportIdList { get; set; }

        /// <summary>
        /// 查询的开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
