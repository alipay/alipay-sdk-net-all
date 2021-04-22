using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceBikepriceGetResponse.
    /// </summary>
    public class AlipayDataAiserviceBikepriceGetResponse : AopResponse
    {
        /// <summary>
        /// 返回结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("card_price_response_item")]
        public List<CardPriceResponseItem> Result { get; set; }
    }
}
