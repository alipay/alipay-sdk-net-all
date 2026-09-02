using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBrandDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBrandDTO : AopObject
    {
        /// <summary>
        /// 支付宝品牌心智slogan
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 支付宝产品图标地址链接
        /// </summary>
        [XmlElement("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 支付宝产品文案标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
