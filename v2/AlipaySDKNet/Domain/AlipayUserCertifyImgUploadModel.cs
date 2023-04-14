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
        /// 标识一个业务证件的ID；如果没有可以传UUID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 证件类型；参考com.alipay.cif.model.core.emuns.CertTypeEnum
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 图片对应的base64字符串
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 图片类型；FACE正面，VERSO背面
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 指定图片的存储类型，SFS与OSS,目前只有这两个值，个人图片要指定为SFS，企业类型图片要指定为OSS
        /// </summary>
        [XmlElement("storage_type")]
        public string StorageType { get; set; }
    }
}
