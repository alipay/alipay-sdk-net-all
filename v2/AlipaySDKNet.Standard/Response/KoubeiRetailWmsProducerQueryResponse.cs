using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsProducerQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsProducerQueryResponse : AopResponse
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
