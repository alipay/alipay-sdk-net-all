using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPaymrchdataQrcodeCreateResponse.
    /// </summary>
    public class AlipayMerchantPaymrchdataQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 经营码开通结果
        /// </summary>
        [XmlElement("open_result")]
        public bool OpenResult { get; set; }
    }
}
