using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionAuthorizationApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionAuthorizationApplyModel : AopObject
    {
        /// <summary>
        /// 需要在尾部添加时间戳，格式为yyyyMMdd
        /// </summary>
        [XmlElement("apply_request_no")]
        public string ApplyRequestNo { get; set; }

        /// <summary>
        /// 用户签署协议列表
        /// </summary>
        [XmlArray("authorization_list")]
        [XmlArrayItem("string")]
        public List<string> AuthorizationList { get; set; }

        /// <summary>
        /// 不同的业务场景下对应不同的业务规则
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 签约协议授权方支付宝openid
        /// </summary>
        [XmlElement("merchant_alipay_open_id")]
        public string MerchantAlipayOpenId { get; set; }

        /// <summary>
        /// 签约协议授权方支付宝uid
        /// </summary>
        [XmlElement("merchant_alipay_uid")]
        public string MerchantAlipayUid { get; set; }

        /// <summary>
        /// 协会、商户在银行侧自行创建的结算户账户户号
        /// </summary>
        [XmlElement("parent_ext_account_no")]
        public string ParentExtAccountNo { get; set; }
    }
}
