using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FuelItemExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FuelItemExtInfo : AopObject
    {
        /// <summary>
        /// MY_KEY
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息的值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
