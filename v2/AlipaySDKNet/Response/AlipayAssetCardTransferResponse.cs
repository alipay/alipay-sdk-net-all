using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetCardTransferResponse.
    /// </summary>
    public class AlipayAssetCardTransferResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单id
        /// </summary>
        [XmlElement("asset_order_id")]
        public string AssetOrderId { get; set; }
    }
}
