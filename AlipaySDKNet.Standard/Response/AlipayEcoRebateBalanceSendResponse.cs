using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoRebateBalanceSendResponse.
    /// </summary>
    public class AlipayEcoRebateBalanceSendResponse : AopResponse
    {
        /// <summary>
        /// 给用户发放集分宝的数量
        /// </summary>
        [XmlElement("jfb_amount")]
        public string JfbAmount { get; set; }
    }
}
