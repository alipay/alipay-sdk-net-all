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
        /// 111
        /// </summary>
        [XmlElement("out")]
        public ActivityGoods Out { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("yyy")]
        public string Yyy { get; set; }
    }
}
