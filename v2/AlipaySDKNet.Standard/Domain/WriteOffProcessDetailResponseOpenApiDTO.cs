using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WriteOffProcessDetailResponseOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WriteOffProcessDetailResponseOpenApiDTO : AopObject
    {
        /// <summary>
        /// 真正核销单据对应的单据号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 核销对象PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 与之核销的对方单据号
        /// </summary>
        [XmlElement("opposite_bill_no")]
        public string OppositeBillNo { get; set; }

        /// <summary>
        /// 与申请核销的单据匹配对应的单据类型 COLLECT_RECEIPT("COLLECT_RECEIPT"), SETTLE_ORDER("SETTLE_ORDER"),
        /// </summary>
        [XmlElement("opposite_writeoffable_bill_type")]
        public string OppositeWriteoffableBillType { get; set; }

        /// <summary>
        /// 核销金额
        /// </summary>
        [XmlElement("writeoff_amt")]
        public MultiCurrencyMoneyOpenApi WriteoffAmt { get; set; }

        /// <summary>
        /// 核销单据的类型 COLLECT_RECEIPT("COLLECT_RECEIPT"), SETTLE_ORDER("SETTLE_ORDER"),
        /// </summary>
        [XmlElement("writeoffable_bill_type")]
        public string WriteoffableBillType { get; set; }
    }
}
