using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinauctionAuctionsucNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinauctionAuctionsucNotifyModel : AopObject
    {
        /// <summary>
        /// 星河申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 尾款支付截止时间
        /// </summary>
        [XmlElement("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 成交价，单位为分
        /// </summary>
        [XmlElement("deal_price")]
        public long DealPrice { get; set; }

        /// <summary>
        /// 拍下时间
        /// </summary>
        [XmlElement("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 保证金金额，单位为分
        /// </summary>
        [XmlElement("foregift_price")]
        public long ForegiftPrice { get; set; }

        /// <summary>
        /// 处置机构账户名
        /// </summary>
        [XmlElement("institution_account_name")]
        public string InstitutionAccountName { get; set; }

        /// <summary>
        /// 处置机构银行账号
        /// </summary>
        [XmlElement("institution_bank_account")]
        public string InstitutionBankAccount { get; set; }

        /// <summary>
        /// 处置机构开户行联行号
        /// </summary>
        [XmlElement("institution_bank_code")]
        public string InstitutionBankCode { get; set; }

        /// <summary>
        /// 处置机构开户行名称
        /// </summary>
        [XmlElement("institution_bank_name")]
        public string InstitutionBankName { get; set; }

        /// <summary>
        /// 外部订单号（阿里拍卖单号）
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 转账附言
        /// </summary>
        [XmlElement("payment_remark")]
        public string PaymentRemark { get; set; }
    }
}
