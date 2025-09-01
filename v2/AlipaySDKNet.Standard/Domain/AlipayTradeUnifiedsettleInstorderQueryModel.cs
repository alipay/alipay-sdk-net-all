using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeUnifiedsettleInstorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeUnifiedsettleInstorderQueryModel : AopObject
    {
        /// <summary>
        /// 金额筛选上限，币种为人民币
        /// </summary>
        [XmlElement("amount_range_end")]
        public string AmountRangeEnd { get; set; }

        /// <summary>
        /// 金额筛选下限，币种为人民币
        /// </summary>
        [XmlElement("amount_range_start")]
        public string AmountRangeStart { get; set; }

        /// <summary>
        /// 明细查询的结束时间，最晚时间
        /// </summary>
        [XmlElement("date_range_end")]
        public string DateRangeEnd { get; set; }

        /// <summary>
        /// 查询明细的开始时间，最早的时间
        /// </summary>
        [XmlElement("date_range_start")]
        public string DateRangeStart { get; set; }

        /// <summary>
        /// 收结易来账明细的单据号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 基于来账付款方的卡号进行筛选
        /// </summary>
        [XmlElement("payer_card_no")]
        public string PayerCardNo { get; set; }

        /// <summary>
        /// 付款方机构/银行编码
        /// </summary>
        [XmlElement("payer_inst_id")]
        public string PayerInstId { get; set; }

        /// <summary>
        /// 平台签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 请求数据的量
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 来账状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
