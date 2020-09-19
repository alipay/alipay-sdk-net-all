using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayApplepayTransactionBatchqueryResponse.
    /// </summary>
    public class AlipayPayApplepayTransactionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("last_updated_tag")]
        public string LastUpdatedTag { get; set; }

        /// <summary>
        /// 头部
        /// </summary>
        [XmlElement("response_header")]
        public BaseOpenApiResponseHeaderDTO ResponseHeader { get; set; }

        /// <summary>
        /// 支付记录列表
        /// </summary>
        [XmlArray("transaction_details")]
        [XmlArrayItem("transaction_detail_d_t_o")]
        public List<TransactionDetailDTO> TransactionDetails { get; set; }
    }
}
