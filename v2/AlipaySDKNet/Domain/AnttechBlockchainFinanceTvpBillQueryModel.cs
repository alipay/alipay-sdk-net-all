using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpBillQueryModel : AopObject
    {
        /// <summary>
        /// 账单id，数科唯一
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 外部账单id，商户唯一
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 账单管理产品实例ID
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
