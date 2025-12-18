using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceBillInfo : AopObject
    {
        /// <summary>
        /// 子单状态
        /// </summary>
        [XmlElement("bill_state")]
        public string BillState { get; set; }

        /// <summary>
        /// 子单类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 子单详情
        /// </summary>
        [XmlElement("detail_info")]
        public string DetailInfo { get; set; }

        /// <summary>
        /// 子单id
        /// </summary>
        [XmlElement("finance_bill_id")]
        public string FinanceBillId { get; set; }
    }
}
