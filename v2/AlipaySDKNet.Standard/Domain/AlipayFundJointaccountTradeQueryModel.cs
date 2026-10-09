using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountTradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountTradeQueryModel : AopObject
    {
        /// <summary>
        /// 企业账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 三方授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员ID，消费发起人
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 消费发起人的openId
        /// </summary>
        [XmlElement("member_open_id")]
        public string MemberOpenId { get; set; }

        /// <summary>
        /// 外部平台订单号。使用该参数查询时，返回结果见trade_info_list
        /// </summary>
        [XmlElement("platform_order_id")]
        public string PlatformOrderId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
