using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessSceneUrl Data Structure.
    /// </summary>
    [Serializable]
    public class AccessSceneUrl : AopObject
    {
        /// <summary>
        /// 跳转url信息
        /// </summary>
        [XmlElement("access_url")]
        public string AccessUrl { get; set; }

        /// <summary>
        /// scheme地址
        /// </summary>
        [XmlElement("scheme_url")]
        public string SchemeUrl { get; set; }

        /// <summary>
        /// url文案信息
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
