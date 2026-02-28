using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlaySourceMediaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlaySourceMediaInfo : AopObject
    {
        /// <summary>
        /// 素材ID，对应“支付宝文件上传接口”获取的file_id
        /// </summary>
        [XmlElement("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 素材类型。 video：视频 cover_static：静态封面
        /// </summary>
        [XmlElement("media_type")]
        public string MediaType { get; set; }
    }
}
