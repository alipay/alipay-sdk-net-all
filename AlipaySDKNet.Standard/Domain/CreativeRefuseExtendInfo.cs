using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeRefuseExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeRefuseExtendInfo : AopObject
    {
        /// <summary>
        /// 创意审核拒绝的附加信息之图片列表
        /// </summary>
        [XmlArray("image_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImageUrlList { get; set; }
    }
}
