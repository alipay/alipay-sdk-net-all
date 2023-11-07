using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDeductionorderPageBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDeductionorderPageBatchqueryModel : AopObject
    {
        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 实际扣款结束时间
        /// </summary>
        [XmlElement("deduction_end_date")]
        public string DeductionEndDate { get; set; }

        /// <summary>
        /// 扣款单id
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 实际扣款开始时间
        /// </summary>
        [XmlElement("deduction_start_date")]
        public string DeductionStartDate { get; set; }

        /// <summary>
        /// 扣款状态
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 下单结束时间
        /// </summary>
        [XmlElement("order_end_date")]
        public string OrderEndDate { get; set; }

        /// <summary>
        /// 下单开始时间
        /// </summary>
        [XmlElement("order_start_date")]
        public string OrderStartDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分账状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }
    }
}
