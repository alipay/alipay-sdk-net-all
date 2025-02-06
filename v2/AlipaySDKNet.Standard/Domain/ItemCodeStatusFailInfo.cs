using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCodeStatusFailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCodeStatusFailInfo : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// app方商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
