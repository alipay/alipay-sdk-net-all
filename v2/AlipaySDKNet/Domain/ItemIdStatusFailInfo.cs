using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemIdStatusFailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemIdStatusFailInfo : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品平台id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
