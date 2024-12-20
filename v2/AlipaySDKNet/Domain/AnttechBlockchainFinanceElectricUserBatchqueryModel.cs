using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceElectricUserBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceElectricUserBatchqueryModel : AopObject
    {
        /// <summary>
        /// 合约码
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 分页参数页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页参数查询页实例数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
