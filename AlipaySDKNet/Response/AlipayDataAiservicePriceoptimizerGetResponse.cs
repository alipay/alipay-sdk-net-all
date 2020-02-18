using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiservicePriceoptimizerGetResponse.
    /// </summary>
    public class AlipayDataAiservicePriceoptimizerGetResponse : AopResponse
    {
        /// <summary>
        /// 推荐价格返回列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("make_price_result")]
        public List<MakePriceResult> Result { get; set; }
    }
}
