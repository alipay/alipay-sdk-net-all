using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionFeeGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExtensionFeeGetResponse : AopResponse
    {
        /// <summary>
        /// 各计费项单价
        /// </summary>
        [XmlArray("fee_item_prices")]
        [XmlArrayItem("fee_item_price")]
        public List<FeeItemPrice> FeeItemPrices { get; set; }
    }
}
