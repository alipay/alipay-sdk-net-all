using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyImgUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyImgUploadModel : AopObject
    {
        /// <summary>
        /// 业务来源，用于支付宝认证系统识别是哪个业务方
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 图片对应的base64字符串
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 指定图片的存储类型，SFS与OSS,目前只有这两个值，个人图片要指定为SFS，企业类型图片要指定为OSS
        /// </summary>
        [XmlElement("storage_type")]
        public string StorageType { get; set; }
    }
}
