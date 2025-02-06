using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCodeStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCodeStatusInfo : AopObject
    {
        /// <summary>
        /// app方商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品状态, 0上架, -1下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
