using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenNimitzdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeopenNimitzdataQueryModel : AopObject
    {
        /// <summary>
        /// 行情数据集请求
        /// </summary>
        [XmlElement("dataset_request")]
        public DatasetRequest DatasetRequest { get; set; }

        /// <summary>
        /// 请求唯一id，用于排查问题
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
