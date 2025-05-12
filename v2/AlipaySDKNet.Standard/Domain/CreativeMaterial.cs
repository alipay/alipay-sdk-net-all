using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeMaterial : AopObject
    {
        /// <summary>
        /// 素材业务类型 根据前置API接口创意模版定义进行填充
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 素材文件类型 IMG:图片 VIDEO:视频 TITLE:标题/副标题 DESC:描述 来区分文案和素材库Id
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 图片或者视频的url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 图片/视频采用素材库ID 如果是文案描述类则传入文案值即可
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
