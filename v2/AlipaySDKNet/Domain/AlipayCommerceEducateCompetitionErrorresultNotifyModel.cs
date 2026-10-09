using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCompetitionErrorresultNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCompetitionErrorresultNotifyModel : AopObject
    {
        /// <summary>
        /// 异常类型
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 异常原因描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 外部赛事id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
