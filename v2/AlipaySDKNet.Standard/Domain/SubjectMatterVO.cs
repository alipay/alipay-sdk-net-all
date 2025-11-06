using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubjectMatterVO Data Structure.
    /// </summary>
    [Serializable]
    public class SubjectMatterVO : AopObject
    {
        /// <summary>
        /// 标的key 可选值 1.province-省份 2.city-城市 3.country-地区 4.address-详细地址
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 标的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
