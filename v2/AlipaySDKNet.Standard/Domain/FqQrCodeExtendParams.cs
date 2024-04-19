using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FqQrCodeExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class FqQrCodeExtendParams : AopObject
    {
        /// <summary>
        /// 当码类型是clerkQrcode(店员码)的时候需要传递此字段
        /// </summary>
        [XmlElement("bind_type")]
        public string BindType { get; set; }

        /// <summary>
        /// 分期数
        /// </summary>
        [XmlElement("fq_num")]
        public string FqNum { get; set; }

        /// <summary>
        /// 当码类型为clerkQrcode(店员码)时需要传递此值
        /// </summary>
        [XmlElement("scene_tag")]
        public string SceneTag { get; set; }
    }
}
