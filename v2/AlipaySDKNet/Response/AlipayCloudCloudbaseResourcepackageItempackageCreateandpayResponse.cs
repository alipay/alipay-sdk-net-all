using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageItempackageCreateandpayResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageItempackageCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 单项资源包下单并支付结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
