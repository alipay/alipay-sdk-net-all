using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentSkuAttrInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentSkuAttrInfo : AopObject
    {
        /// <summary>
        /// 属性key，例如 品牌对应 brand，通过alipay.open.app.item.cateattr.query接口获取
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }

        /// <summary>
        /// 属性值ID
        /// </summary>
        [XmlElement("attr_value_id")]
        public string AttrValueId { get; set; }
    }
}
