using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceExtInfo : AopObject
    {
        /// <summary>
        /// 服务扩展信息
        /// </summary>
        [XmlElement("promo_text")]
        public string PromoText { get; set; }
    }
}
