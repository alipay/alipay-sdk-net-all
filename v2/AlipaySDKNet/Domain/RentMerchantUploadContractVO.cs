using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentMerchantUploadContractVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentMerchantUploadContractVO : AopObject
    {
        /// <summary>
        /// 合同文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 合同文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 合同上传时间
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }
    }
}
