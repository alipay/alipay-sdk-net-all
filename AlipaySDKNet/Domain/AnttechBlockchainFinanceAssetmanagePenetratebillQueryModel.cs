using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetmanagePenetratebillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAssetmanagePenetratebillQueryModel : AopObject
    {
        /// <summary>
        /// 产品合约代码
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 账单日期，格式根据账单类型而定 日账单格式示例：20210908
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单周期类型 DAY：日账单
        /// </summary>
        [XmlElement("bill_period")]
        public string BillPeriod { get; set; }
    }
}
