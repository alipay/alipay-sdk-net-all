using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupEntryCreateResponse.
    /// </summary>
    public class AlipayMerchantGroupEntryCreateResponse : AopResponse
    {
        /// <summary>
        /// 用户绑定链接
        /// </summary>
        [XmlElement("binding_link")]
        public string BindingLink { get; set; }
    }
}
