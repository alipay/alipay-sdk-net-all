using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardServicestockSyncResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardServicestockSyncResponse : AopResponse
    {
        /// <summary>
        /// 服务id【必填】
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
