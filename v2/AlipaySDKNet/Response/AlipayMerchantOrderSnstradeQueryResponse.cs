using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantOrderSnstradeQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderSnstradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 动销数据
        /// </summary>
        [XmlArray("data_results")]
        [XmlArrayItem("sns_trade_data_result")]
        public List<SnsTradeDataResult> DataResults { get; set; }
    }
}
