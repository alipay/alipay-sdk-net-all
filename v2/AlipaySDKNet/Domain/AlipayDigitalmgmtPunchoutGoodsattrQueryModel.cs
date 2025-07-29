using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutGoodsattrQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtPunchoutGoodsattrQueryModel : AopObject
    {
        /// <summary>
        /// 属性值集合，包含属性Id属性名称，属性值Id。属性值名称
        /// </summary>
        [XmlArray("attr_value_list")]
        [XmlArrayItem("mall_attr_value")]
        public List<MallAttrValue> AttrValueList { get; set; }

        /// <summary>
        /// 是否查询有效数据，默认查询有效数据
        /// </summary>
        [XmlElement("is_valid")]
        public string IsValid { get; set; }

        /// <summary>
        /// 查询数据的当前页数据，入参1 查询第1页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询到的数据最大返回值,传参50 最多只返回50条数据
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
