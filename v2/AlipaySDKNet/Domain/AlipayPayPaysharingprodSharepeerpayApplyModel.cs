using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayPaysharingprodSharepeerpayApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayPaysharingprodSharepeerpayApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝userId，表示代付订单申请人
        /// </summary>
        [XmlElement("alipay_applyer_id")]
        public string AlipayApplyerId { get; set; }

        /// <summary>
        /// 支付宝交易单号，合并支付订单号用;分隔
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 代付申请人
        /// </summary>
        [XmlElement("applyer_open_id")]
        public string ApplyerOpenId { get; set; }

        /// <summary>
        /// 如果没有传入alipay_user_id，该external_user_token需要传入用于申请人用户发现
        /// </summary>
        [XmlElement("external_user_token")]
        public string ExternalUserToken { get; set; }

        /// <summary>
        /// 分享代付安全参数信息
        /// </summary>
        [XmlElement("security_info")]
        public SharePeerPaySecurityInfo SecurityInfo { get; set; }
    }
}
