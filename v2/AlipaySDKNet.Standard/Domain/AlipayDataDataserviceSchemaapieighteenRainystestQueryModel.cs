using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapieighteenRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemaapieighteenRainystestQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("boolean_list")]
        [XmlArrayItem("boolean")]
        public List<bool> BooleanList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_list")]
        [XmlArrayItem("date")]
        public List<string> DateList { get; set; }

        /// <summary>
        /// 基础描述
        /// </summary>
        [XmlElement("num_ext_value")]
        public long NumExtValue { get; set; }

        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("num_must")]
        public long NumMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("num_must_list")]
        [XmlArrayItem("number")]
        public List<long> NumMustList { get; set; }

        /// <summary>
        /// 基础参数num
        /// </summary>
        [XmlElement("num_optional")]
        public long NumOptional { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("num_optional_list")]
        [XmlArrayItem("number")]
        public List<long> NumOptionalList { get; set; }

        /// <summary>
        /// 基础参数，单位元；
        /// </summary>
        [XmlElement("price_exat_value")]
        public string PriceExatValue { get; set; }

        /// <summary>
        /// 基础参数，单位元；
        /// </summary>
        [XmlElement("price_must")]
        public string PriceMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("price_must_list")]
        [XmlArrayItem("price")]
        public List<string> PriceMustList { get; set; }

        /// <summary>
        /// 基础参数，单位元；
        /// </summary>
        [XmlElement("price_optional")]
        public string PriceOptional { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("price_optional_list")]
        [XmlArrayItem("price")]
        public List<string> PriceOptionalList { get; set; }

        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("string_enum")]
        public string StringEnum { get; set; }

        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("string_must")]
        public string StringMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("string_must_list")]
        [XmlArrayItem("string")]
        public List<string> StringMustList { get; set; }

        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("string_optional")]
        public string StringOptional { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("string_optional_list")]
        [XmlArrayItem("string")]
        public List<string> StringOptionalList { get; set; }

        /// <summary>
        /// 基础描述
        /// </summary>
        [XmlElement("string_pattern")]
        public string StringPattern { get; set; }
    }
}
