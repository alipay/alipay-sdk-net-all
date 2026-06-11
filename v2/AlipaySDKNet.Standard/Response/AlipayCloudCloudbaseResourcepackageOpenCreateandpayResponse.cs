using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageOpenCreateandpayResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageOpenCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 外部环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
