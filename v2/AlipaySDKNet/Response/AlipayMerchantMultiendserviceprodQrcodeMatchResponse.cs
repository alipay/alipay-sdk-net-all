using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMultiendserviceprodQrcodeMatchResponse.
    /// </summary>
    public class AlipayMerchantMultiendserviceprodQrcodeMatchResponse : AopResponse
    {
        /// <summary>
        /// 是否支持支付宝缴费
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
