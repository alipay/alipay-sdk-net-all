using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSkuAttrDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSkuAttrDTO : AopObject
    {
        /// <summary>
        /// 回收商品销售属性code值，对应回收问券的问题code值
        /// </summary>
        [XmlElement("attr_code")]
        public string AttrCode { get; set; }

        /// <summary>
        /// 回收商品的销售属性值，对应回收问券的选项code值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
