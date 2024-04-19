using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntOcrTesConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntOcrTesConsultModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oooo")]
        public string Oooo { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("out")]
        public ActivityGoods Out { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ss")]
        public string Ss { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sssss")]
        public string Sssss { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("trhee")]
        public string Trhee { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("yyy")]
        public string Yyy { get; set; }
    }
}
