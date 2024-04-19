using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeSubaccountCreateResponse.
    /// </summary>
    public class MybankPaymentTradeSubaccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 银行联行号
        /// </summary>
        [XmlElement("branch_no")]
        public string BranchNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 开户时间戳（yyyyMMddHHmmss）
        /// </summary>
        [XmlElement("open_account_time")]
        public string OpenAccountTime { get; set; }

        /// <summary>
        /// 外部渠道ID
        /// </summary>
        [XmlElement("out_channel_id")]
        public string OutChannelId { get; set; }

        /// <summary>
        /// 母户卡号
        /// </summary>
        [XmlElement("parent_card_no")]
        public string ParentCardNo { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台判断是否需要重试，失败时有值，true=需要重试，false=不需要重试，是否重试可以由业务决定
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 子户卡号
        /// </summary>
        [XmlElement("sub_card_no")]
        public string SubCardNo { get; set; }
    }
}
