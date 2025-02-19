using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpBillBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分页查询，页码。从 0 开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_account")]
        public TrustAccountInfo PayeeAccount { get; set; }

        /// <summary>
        /// 收款方主体
        /// </summary>
        [XmlElement("payee_entity")]
        public TrustEntityInfo PayeeEntity { get; set; }

        /// <summary>
        /// 付款方
        /// </summary>
        [XmlElement("payer_entity")]
        public TrustEntityInfo PayerEntity { get; set; }

        /// <summary>
        /// 可信价值中心产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 查询日期
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }
    }
}
