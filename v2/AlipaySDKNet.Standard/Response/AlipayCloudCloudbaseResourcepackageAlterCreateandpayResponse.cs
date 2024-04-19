using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageAlterCreateandpayResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageAlterCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 变配下单并支付结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
