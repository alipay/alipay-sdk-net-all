using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingAssetFundUseResponse.
    /// </summary>
    public class AlipayMarketingAssetFundUseResponse : AopResponse
    {
        /// <summary>
        /// 当笔资产资金核销操作的流水id
        /// </summary>
        [XmlElement("use_order_id")]
        public string UseOrderId { get; set; }
    }
}
