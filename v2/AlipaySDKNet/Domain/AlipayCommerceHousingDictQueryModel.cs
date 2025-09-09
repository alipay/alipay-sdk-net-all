using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingDictQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingDictQueryModel : AopObject
    {
        /// <summary>
        /// 单个值，非固定枚举值
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 枚举类型(二手房/租房/独栋/小区/楼盘)
        /// </summary>
        [XmlElement("enum_type")]
        public string EnumType { get; set; }
    }
}
