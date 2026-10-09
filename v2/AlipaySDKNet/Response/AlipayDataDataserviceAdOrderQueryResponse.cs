using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOrderQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlElement("order_detail")]
        public OpenOrderDetail OrderDetail { get; set; }
    }
}
