using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtccardTradeSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtccardTradeSyncResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public long BizNo { get; set; }
    }
}
