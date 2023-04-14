using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudResumeHeadPic Data Structure.
    /// </summary>
    [Serializable]
    public class CloudResumeHeadPic : AopObject
    {
        /// <summary>
        /// 头像连接url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
