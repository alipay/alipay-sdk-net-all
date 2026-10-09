using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoCumAccruedBalanceAmtDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PoCumAccruedBalanceAmtDetailDTO : AopObject
    {
        /// <summary>
        /// 累计预提金额
        /// </summary>
        [XmlElement("cum_accrued_balance_amt")]
        public long CumAccruedBalanceAmt { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// po key (id)
        /// </summary>
        [XmlElement("po_key")]
        public long PoKey { get; set; }

        /// <summary>
        /// po行号
        /// </summary>
        [XmlElement("po_line_no")]
        public string PoLineNo { get; set; }

        /// <summary>
        /// PO单号
        /// </summary>
        [XmlElement("po_no")]
        public string PoNo { get; set; }
    }
}
