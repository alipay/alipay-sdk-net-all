using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingTicketstubPurchaseSyncResponse.
    /// </summary>
    public class AlipayOfflineMarketingTicketstubPurchaseSyncResponse : AopResponse
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
