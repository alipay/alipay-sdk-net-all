using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutPromoInfo : AopObject
    {
        /// <summary>
        /// 标记外部访问来源，biqiang、1688
        /// </summary>
        [XmlElement("out_scene")]
        public string OutScene { get; set; }
    }
}
