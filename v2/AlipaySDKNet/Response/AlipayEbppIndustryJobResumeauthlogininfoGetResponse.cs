using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobResumeauthlogininfoGetResponse.
    /// </summary>
    public class AlipayEbppIndustryJobResumeauthlogininfoGetResponse : AopResponse
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("resume_attributes")]
        [XmlArrayItem("resume_attribute")]
        public List<ResumeAttribute> ResumeAttributes { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 求职意向
        /// </summary>
        [XmlElement("user_intention_info")]
        public UserIntentionInfo UserIntentionInfo { get; set; }
    }
}
