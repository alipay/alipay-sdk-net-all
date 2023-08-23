using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageRenewCreateandpayResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageRenewCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 续费下单并支付结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
