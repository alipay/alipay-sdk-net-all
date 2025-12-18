using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingQualificationConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingQualificationConsultModel : AopObject
    {
        /// <summary>
        /// 业务上下文信息
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qual_consult_infos")]
        [XmlArrayItem("qualification_consult_info")]
        public List<QualificationConsultInfo> QualConsultInfos { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
