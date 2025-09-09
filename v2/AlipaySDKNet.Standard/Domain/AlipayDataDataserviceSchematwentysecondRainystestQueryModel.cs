using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchematwentysecondRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchematwentysecondRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_boolean")]
        public bool DemoBoolean { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_date")]
        public string DemoDate { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_num")]
        public long DemoNum { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_price")]
        public string DemoPrice { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("demo_string")]
        public string DemoString { get; set; }

        /// <summary>
        /// TEST DATA
        /// </summary>
        [XmlElement("first_wink_ref")]
        public RainyComplexTypesRefWeakFourth FirstWinkRef { get; set; }

        /// <summary>
        /// 强引用
        /// </summary>
        [XmlElement("firstlevel_ref")]
        public RainyComplexTypesTheFourth FirstlevelRef { get; set; }

        /// <summary>
        /// 第一层的N选一
        /// </summary>
        [XmlElement("firstlevel_string_1")]
        public string FirstlevelString1 { get; set; }

        /// <summary>
        /// 第一层的openID数据
        /// </summary>
        [XmlElement("firstlevel_string_1_open_id")]
        public string FirstlevelString1OpenId { get; set; }

        /// <summary>
        /// 第一层的N选一
        /// </summary>
        [XmlElement("firstlevel_string_2")]
        public string FirstlevelString2 { get; set; }

        /// <summary>
        /// 第一层的N选一
        /// </summary>
        [XmlElement("firstlevel_string_2_open_id")]
        public string FirstlevelString2OpenId { get; set; }
    }
}
