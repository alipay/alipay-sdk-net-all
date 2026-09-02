using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentProcurementInactiveCheckResponse.
    /// </summary>
    public class AlipayCommerceRentProcurementInactiveCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否需要当面激活标签
        /// </summary>
        [XmlElement("activation_label")]
        public string ActivationLabel { get; set; }
    }
}
