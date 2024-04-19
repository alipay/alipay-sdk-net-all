using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityConsultModel : AopObject
    {
        /// <summary>
        /// 待咨询的活动信息列表
        /// </summary>
        [XmlArray("consult_activity_info_list")]
        [XmlArrayItem("consult_activity_info")]
        public List<ConsultActivityInfo> ConsultActivityInfoList { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 商户PID,默认为当前接口调用商户。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 领券的支付宝用户openId
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
