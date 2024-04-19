using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenAppDemoTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppDemoTestQueryModel : AopObject
    {
        /// <summary>
        /// copy_complex
        /// </summary>
        [XmlArray("copy_complex")]
        [XmlArrayItem("public_complex")]
        public List<PublicComplex> CopyComplex { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        [XmlElement("platform_a")]
        public string PlatformA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("ref_complex")]
        public PublicComplex RefComplex { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_1")]
        public string Test1 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_date")]
        public string TestDate { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(111111111111)
        /// </summary>
        [XmlElement("test_number")]
        public string TestNumber { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_other")]
        public string TestOther { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_price")]
        public string TestPrice { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_string_open_id")]
        public string TestStringOpenId { get; set; }
    }
}
