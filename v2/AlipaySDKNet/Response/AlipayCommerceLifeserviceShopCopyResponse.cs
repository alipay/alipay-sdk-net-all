using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopCopyResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceShopCopyResponse : AopResponse
    {
        /// <summary>
        /// 复制完成
        /// </summary>
        [XmlElement("copy_result")]
        public string CopyResult { get; set; }
    }
}
