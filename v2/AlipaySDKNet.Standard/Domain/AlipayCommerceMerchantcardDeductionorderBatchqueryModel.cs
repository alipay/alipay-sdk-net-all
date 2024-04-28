using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardDeductionorderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 订购单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 订单结束时间
        /// </summary>
        [XmlElement("deduction_end_date")]
        public string DeductionEndDate { get; set; }

        /// <summary>
        /// 订单开始时间
        /// </summary>
        [XmlElement("deduction_start_date")]
        public string DeductionStartDate { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 订购结束时间
        /// </summary>
        [XmlElement("order_end_date")]
        public string OrderEndDate { get; set; }

        /// <summary>
        /// 订购开始时间
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
    }
}
