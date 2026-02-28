using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceItemInfo : AopObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
