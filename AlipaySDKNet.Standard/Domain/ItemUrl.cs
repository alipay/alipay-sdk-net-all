using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUrl Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUrl : AopObject
    {
        /// <summary>
        /// 地址类型；可选值: SC_MINI_APP(支付宝小程序)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 商品详情地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
