using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyTheTwiceComplexTestAllList Data Structure.
    /// </summary>
    [Serializable]
    public class RainyTheTwiceComplexTestAllList : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("bool_list_must")]
        [XmlArrayItem("boolean")]
        public List<bool> BoolListMust { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("bool_must")]
        public bool BoolMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("boolean_list_optional")]
        [XmlArrayItem("boolean")]
        public List<bool> BooleanListOptional { get; set; }

        /// <summary>
        /// boolean_optional
        /// </summary>
        [XmlElement("boolean_optional")]
        public bool BooleanOptional { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_list_must")]
        [XmlArrayItem("date")]
        public List<string> DateListMust { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("date_must")]
        public string DateMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("num_list_must")]
        [XmlArrayItem("number")]
        public List<long> NumListMust { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("num_must")]
        public long NumMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("number_list_optional")]
        [XmlArrayItem("number")]
        public List<long> NumberListOptional { get; set; }

        /// <summary>
        /// number_optional
        /// </summary>
        [XmlElement("number_optional")]
        public long NumberOptional { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("price_list_must")]
        [XmlArrayItem("price")]
        public List<string> PriceListMust { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("price_must")]
        public string PriceMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("string_list_must")]
        [XmlArrayItem("string")]
        public List<string> StringListMust { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("string_list_optional")]
        [XmlArrayItem("string")]
        public List<string> StringListOptional { get; set; }

        /// <summary>
        /// string_optional
        /// </summary>
        [XmlElement("string_list_optional_rainy")]
        public string StringListOptionalRainy { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("string_must")]
        public string StringMust { get; set; }

        /// <summary>
        /// string_optional
        /// </summary>
        [XmlElement("string_optional")]
        public string StringOptional { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("string_regex_ip")]
        public string StringRegexIp { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("string_regex_num")]
        public string StringRegexNum { get; set; }
    }
}
