using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodRuleGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseAntifloodRuleGetResponse : AopResponse
    {
        /// <summary>
        /// IP或IP段
        /// </summary>
        [XmlElement("cidr_block")]
        public string CidrBlock { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 规则来源  - BARRIER  - BLACKLIST
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }
    }
}
