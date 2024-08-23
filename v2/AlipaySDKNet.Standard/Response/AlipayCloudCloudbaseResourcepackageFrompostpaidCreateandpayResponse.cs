using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageFrompostpaidCreateandpayResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageFrompostpaidCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 按量转套餐开通下单支付结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
