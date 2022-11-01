using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityConsultResponse.
    /// </summary>
    public class AlipayMarketingActivityConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询后的活动结果信息
        /// </summary>
        [XmlArray("consult_result_info_list")]
        [XmlArrayItem("consult_activity_result_info")]
        public List<ConsultActivityResultInfo> ConsultResultInfoList { get; set; }

        /// <summary>
        /// 领券的用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 领券的用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
