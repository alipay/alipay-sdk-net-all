using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CedsipeihuanCcomplex Data Structure.
    /// </summary>
    [Serializable]
    public class CedsipeihuanCcomplex : AopObject
    {
        /// <summary>
        /// 特殊可选
        /// </summary>
        [XmlElement("d")]
        public string D { get; set; }

        /// <summary>
        /// 可选 当前字段已废弃(废弃物测试VDC成都市)
        /// </summary>
        [XmlElement("dede")]
        public string Dede { get; set; }

        /// <summary>
        /// 必选
        /// </summary>
        [XmlElement("fgrf")]
        public string Fgrf { get; set; }

        /// <summary>
        /// 必选
        /// </summary>
        [XmlElement("hdj_open_id")]
        public string HdjOpenId { get; set; }

        /// <summary>
        /// 必选
        /// </summary>
        [XmlElement("sdcd")]
        public string Sdcd { get; set; }
    }
}
