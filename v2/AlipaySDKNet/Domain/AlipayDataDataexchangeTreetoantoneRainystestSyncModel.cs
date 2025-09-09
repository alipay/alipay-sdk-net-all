using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeTreetoantoneRainystestSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeTreetoantoneRainystestSyncModel : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("demo_boolean")]
        public bool DemoBoolean { get; set; }

        /// <summary>
        /// 描述 当前字段已废弃(the test data;Dont care it ;)
        /// </summary>
        [XmlElement("demo_date")]
        public string DemoDate { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("demo_num")]
        public long DemoNum { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_price")]
        public string DemoPrice { get; set; }

        /// <summary>
        /// 啊巴巴
        /// </summary>
        [XmlElement("demo_ref_copy")]
        public RainyComplexTypesRefWeakFirst DemoRefCopy { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("demo_ref_fieldcopy")]
        public RainyComplexTypesRefWeakFirst DemoRefFieldcopy { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlArray("deno_ref")]
        [XmlArrayItem("rainy_complex_types_the_fourth")]
        public List<RainyComplexTypesTheFourth> DenoRef { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
