using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataTimeTongjiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataTimeTongjiQueryModel : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
