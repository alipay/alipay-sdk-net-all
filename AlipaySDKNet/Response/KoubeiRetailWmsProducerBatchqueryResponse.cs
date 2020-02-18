using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsProducerBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsProducerBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 生产厂商信息
        /// </summary>
        [XmlArray("producers")]
        [XmlArrayItem("producer_v_o")]
        public List<ProducerVO> Producers { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
