using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleInstshopQrcodeConsultResponse.
    /// </summary>
    public class AlipayCommerceRecycleInstshopQrcodeConsultResponse : AopResponse
    {
        /// <summary>
        /// 支付宝线下门店扫码创单承接页URL
        /// </summary>
        [XmlElement("alipay_recycle_url")]
        public string AlipayRecycleUrl { get; set; }
    }
}
