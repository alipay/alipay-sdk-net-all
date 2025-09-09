using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpBillCancelModel : AopObject
    {
        /// <summary>
        /// 可信账单ID
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 外部账单Id
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 可信账单产品实例
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 账单撤销备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
