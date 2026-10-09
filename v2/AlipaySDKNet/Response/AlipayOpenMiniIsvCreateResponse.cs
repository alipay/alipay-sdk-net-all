using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIsvCreateResponse.
    /// </summary>
    public class AlipayOpenMiniIsvCreateResponse : AopResponse
    {
        /// <summary>
        /// 小程序代创建订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
