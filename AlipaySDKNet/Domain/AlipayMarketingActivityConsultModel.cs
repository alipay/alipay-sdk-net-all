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
        /// 商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 领券的用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
