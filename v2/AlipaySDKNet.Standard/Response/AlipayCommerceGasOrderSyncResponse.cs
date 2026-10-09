using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceGasOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步成功或失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
