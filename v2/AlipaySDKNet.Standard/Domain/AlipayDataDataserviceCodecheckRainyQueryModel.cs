using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceCodecheckRainyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceCodecheckRainyQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("boolean_a")]
        public bool BooleanA { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("boolean_b")]
        public bool BooleanB { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("diff_boolean_b")]
        public bool DiffBooleanB { get; set; }

        /// <summary>
        /// 1-5
        /// </summary>
        [XmlElement("diff_num_c")]
        public long DiffNumC { get; set; }

        /// <summary>
        /// 1-3
        /// </summary>
        [XmlElement("diff_price_d")]
        public string DiffPriceD { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("diff_string_a")]
        public string DiffStringA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("num_a")]
        public long NumA { get; set; }

        /// <summary>
        /// 99-201
        /// </summary>
        [XmlElement("num_b")]
        public long NumB { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("price_a")]
        public string PriceA { get; set; }

        /// <summary>
        /// 1oo-201
        /// </summary>
        [XmlElement("price_b")]
        public string PriceB { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("string_a")]
        public string StringA { get; set; }

        /// <summary>
        /// a
        /// </summary>
        [XmlElement("string_b")]
        public string StringB { get; set; }
    }
}
