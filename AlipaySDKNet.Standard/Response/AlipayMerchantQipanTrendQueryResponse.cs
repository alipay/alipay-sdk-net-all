using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanTrendQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanTrendQueryResponse : AopResponse
    {
        /// <summary>
        /// 趋势分析数据
        /// </summary>
        [XmlArray("index_trend_results")]
        [XmlArrayItem("index_trend_v_o")]
        public List<IndexTrendVO> IndexTrendResults { get; set; }
    }
}
