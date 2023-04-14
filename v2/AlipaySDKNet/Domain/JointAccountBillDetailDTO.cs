using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountBillDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountBillDetailDTO : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账单业务号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 1-退款，2-支付
        /// </summary>
        [XmlElement("in_out")]
        public string InOut { get; set; }

        /// <summary>
        /// 共同账户消费的成员openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部交易单号，正向支付为外部交易单号，逆向退款是为外部退款单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 间连商户显示二级商户全名，直连、直付通则显示一级商户全名。企业商户该字段不脱敏，非企业商户该字段会脱敏
        /// </summary>
        [XmlElement("seller_full_name")]
        public string SellerFullName { get; set; }

        /// <summary>
        /// 收款方登录号信息。间连商户显示二级商户的登录号信息；直连、直付通显示一级商户的登录号信息；该字段脱敏
        /// </summary>
        [XmlElement("seller_logon_id")]
        public string SellerLogonId { get; set; }

        /// <summary>
        /// 账单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 共同账户消费的成员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
