using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcDistrictQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcDistrictQueryModel : AopObject
    {
        /// <summary>
        /// 行政区划等级
        /// </summary>
        [XmlElement("area_level")]
        public string AreaLevel { get; set; }

        /// <summary>
        /// 父级行政编码
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }
    }
}
