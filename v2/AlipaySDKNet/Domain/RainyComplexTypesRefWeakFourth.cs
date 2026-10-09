using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesRefWeakFourth Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesRefWeakFourth : AopObject
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("seconde_demo_boolean")]
        public bool SecondeDemoBoolean { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("seconde_demo_date")]
        public string SecondeDemoDate { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("seconde_demo_num")]
        public long SecondeDemoNum { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("seconde_demo_price")]
        public string SecondeDemoPrice { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("seconde_demo_string")]
        public string SecondeDemoString { get; set; }
    }
}
