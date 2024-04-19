using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutBasketCreateResponse.
    /// </summary>
    public class AlipayDigitalmgmtPunchoutBasketCreateResponse : AopResponse
    {
        /// <summary>
        /// 合并成功后跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
