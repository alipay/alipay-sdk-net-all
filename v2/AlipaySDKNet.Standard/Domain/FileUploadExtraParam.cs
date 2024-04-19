using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileUploadExtraParam Data Structure.
    /// </summary>
    [Serializable]
    public class FileUploadExtraParam : AopObject
    {
        /// <summary>
        /// 是否同步上传到其他平台。素材类型为视频且需要同步优酷，请必传入参数youku，素材接口将代上传到优酷账号；素材类型为图片，无需传入参数
        /// </summary>
        [XmlElement("extern_upload")]
        public string ExternUpload { get; set; }

        /// <summary>
        /// 文件加密类型
        /// </summary>
        [XmlElement("file_encrypt_type")]
        public string FileEncryptType { get; set; }
    }
}
