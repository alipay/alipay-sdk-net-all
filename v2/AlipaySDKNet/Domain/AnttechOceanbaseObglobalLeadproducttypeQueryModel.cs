using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadproducttypeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalLeadproducttypeQueryModel : AopObject
    {
        /// <summary>
        /// 合作实体bid
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 用于告知请求来源
        /// </summary>
        [XmlElement("request_source")]
        public string RequestSource { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
