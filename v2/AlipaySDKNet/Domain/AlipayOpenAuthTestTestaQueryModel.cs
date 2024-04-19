using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthTestTestaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthTestTestaQueryModel : AopObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }
    }
}
