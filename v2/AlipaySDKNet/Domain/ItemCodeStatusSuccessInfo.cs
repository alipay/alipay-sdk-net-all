using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCodeStatusSuccessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCodeStatusSuccessInfo : AopObject
    {
        /// <summary>
        /// app方商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
