using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FdsPayFundItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FdsPayFundItemDTO : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金业务信息
        /// </summary>
        [XmlElement("fund_biz_info")]
        public string FundBizInfo { get; set; }

        /// <summary>
        /// 条目id
        /// </summary>
        [XmlElement("fund_item_id")]
        public string FundItemId { get; set; }

        /// <summary>
        /// 2021-11-04 14:03:50
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_user_info")]
        public PayUserInfoDTO PayeeUserInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_user_info")]
        public PayUserInfoDTO PayerUserInfo { get; set; }

        /// <summary>
        /// 状态:CR("已创建"),ACC("已受理"),UN("未知"), FA("处理失败"),SU("成功"),CLS("已关闭");
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
