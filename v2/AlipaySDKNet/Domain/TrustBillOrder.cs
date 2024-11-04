using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrustBillOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TrustBillOrder : AopObject
    {
        /// <summary>
        /// 账单支付总金额 ，单位元
        /// </summary>
        [XmlElement("actual_total_amount")]
        public string ActualTotalAmount { get; set; }

        /// <summary>
        /// 账单调整金额 ，单位元
        /// </summary>
        [XmlElement("adjusted_amount")]
        public string AdjustedAmount { get; set; }

        /// <summary>
        /// 账单名称
        /// </summary>
        [XmlElement("bill_name")]
        public string BillName { get; set; }

        /// <summary>
        /// 账单ID,数科唯一
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 状态说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 账单初始总金额，单位元
        /// </summary>
        [XmlElement("original_total_amount")]
        public string OriginalTotalAmount { get; set; }

        /// <summary>
        /// 外部账单ID，商户唯一
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
