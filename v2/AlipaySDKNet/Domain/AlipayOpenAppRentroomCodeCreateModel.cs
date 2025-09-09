using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRentroomCodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRentroomCodeCreateModel : AopObject
    {
        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
