using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCompetitionResultNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCompetitionResultNotifyModel : AopObject
    {
        /// <summary>
        /// 录入结果编码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 外部赛事id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
