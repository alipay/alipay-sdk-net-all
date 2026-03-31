using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KLineListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KLineListDTO : AopObject
    {
        /// <summary>
        /// 数据项，类型为KLineDTO
        /// </summary>
        [XmlElement("items")]
        public KLineDTO Items { get; set; }
    }
}
