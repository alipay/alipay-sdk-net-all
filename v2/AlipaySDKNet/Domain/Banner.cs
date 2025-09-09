using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Banner Data Structure.
    /// </summary>
    [Serializable]
    public class Banner : AopObject
    {
        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }
    }
}
