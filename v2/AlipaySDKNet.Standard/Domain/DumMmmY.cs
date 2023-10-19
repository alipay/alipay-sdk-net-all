using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DumMmmY Data Structure.
    /// </summary>
    [Serializable]
    public class DumMmmY : AopObject
    {
        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
