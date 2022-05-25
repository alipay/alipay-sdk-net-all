using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthPictureUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthPictureUploadModel : AopObject
    {
        /// <summary>
        /// 图片对应的base64字符串，支持jpg和png，1M之内
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 只能传入指定类型，具体类型看文档
        /// </summary>
        [XmlElement("pic_type")]
        public string PicType { get; set; }
    }
}
