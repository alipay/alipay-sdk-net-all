using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeSchemaprodwiceRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataexchangeSchemaprodwiceRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [XmlElement("boolean_01_n_select_one")]
        public bool Boolean01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("boolean_02_n_select_one")]
        [XmlArrayItem("boolean")]
        public List<bool> Boolean02NSelectOne { get; set; }

        /// <summary>
        /// date
        /// </summary>
        [XmlElement("date_01_n_select_one")]
        public string Date01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_02_n_select_one")]
        [XmlArrayItem("date")]
        public List<string> Date02NSelectOne { get; set; }

        /// <summary>
        /// number
        /// </summary>
        [XmlElement("num_01_n_select_one")]
        public long Num01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("num_02_n_select_one")]
        [XmlArrayItem("number")]
        public List<long> Num02NSelectOne { get; set; }

        /// <summary>
        /// price
        /// </summary>
        [XmlElement("price_01_n_select_one")]
        public string Price01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("price_02_n_select_one")]
        [XmlArrayItem("price")]
        public List<string> Price02NSelectOne { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("string_01_n_select_one")]
        public string String01NSelectOne { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("string_02_n_select_one")]
        [XmlArrayItem("string")]
        public List<string> String02NSelectOne { get; set; }
    }
}
