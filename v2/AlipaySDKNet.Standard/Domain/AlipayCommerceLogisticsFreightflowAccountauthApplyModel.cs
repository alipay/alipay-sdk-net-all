using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowAccountauthApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowAccountauthApplyModel : AopObject
    {
        /// <summary>
        /// 格式标准：需要在尾部添加时间戳，格式为yyyyMMdd。 ●外部需要保证重复请求不更换时间戳，否则会导致幂等击穿
        /// </summary>
        [XmlElement("apply_request_no")]
        public string ApplyRequestNo { get; set; }

        /// <summary>
        /// 被授权方。本期：母公司
        /// </summary>
        [XmlElement("authorizee_info")]
        public FreigtFlowAuthAccount AuthorizeeInfo { get; set; }

        /// <summary>
        /// 授权方。本期：子公司
        /// </summary>
        [XmlElement("authorizer_info")]
        public FreigtFlowAuthAccount AuthorizerInfo { get; set; }

        /// <summary>
        /// 格式：yyyyMMddHHmmss
        /// </summary>
        [XmlElement("expiration_time")]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// 由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
