using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopIndustryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopIndustryInfo : AopObject
    {
        /// <summary>
        /// 一级行业
        /// </summary>
        [XmlElement("first_industry")]
        public string FirstIndustry { get; set; }

        /// <summary>
        /// 二级行业
        /// </summary>
        [XmlElement("second_industry")]
        public string SecondIndustry { get; set; }

        /// <summary>
        /// 三级行业
        /// </summary>
        [XmlElement("third_industry")]
        public string ThirdIndustry { get; set; }
    }
}
