using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DynamicDataVO Data Structure.
    /// </summary>
    [Serializable]
    public class DynamicDataVO : AopObject
    {
        /// <summary>
        /// 动态属性列表,列表类型
        /// </summary>
        [XmlArray("attribute_list")]
        [XmlArrayItem("dynamic_attribute_v_o")]
        public List<DynamicAttributeVO> AttributeList { get; set; }

        /// <summary>
        /// 商品动态数据查询Order，返回时将入参带回
        /// </summary>
        [XmlElement("order")]
        public ItemDynamicQueryOrder Order { get; set; }
    }
}
