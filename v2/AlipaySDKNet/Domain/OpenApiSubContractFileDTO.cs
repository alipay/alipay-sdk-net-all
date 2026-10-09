using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSubContractFileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSubContractFileDTO : AopObject
    {
        /// <summary>
        /// 附件文件名
        /// </summary>
        [XmlElement("attachment_file_name")]
        public string AttachmentFileName { get; set; }

        /// <summary>
        /// OSS参数
        /// </summary>
        [XmlElement("attachment_path")]
        public string AttachmentPath { get; set; }

        /// <summary>
        /// 文件http下载链接
        /// </summary>
        [XmlElement("attachment_url")]
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// 定稿时间
        /// </summary>
        [XmlElement("confirm_date")]
        public string ConfirmDate { get; set; }

        /// <summary>
        /// 定稿人
        /// </summary>
        [XmlElement("confirmer")]
        public OpenApiPersonSaDTO Confirmer { get; set; }

        /// <summary>
        /// 合同文件版本
        /// </summary>
        [XmlElement("file_version")]
        public string FileVersion { get; set; }

        /// <summary>
        /// 子合同code
        /// </summary>
        [XmlElement("sub_contract_code")]
        public string SubContractCode { get; set; }

        /// <summary>
        /// 子合同名称
        /// </summary>
        [XmlElement("sub_contract_name")]
        public string SubContractName { get; set; }

        /// <summary>
        /// 子合同定稿状态
        /// </summary>
        [XmlElement("sub_contract_status")]
        public string SubContractStatus { get; set; }

        /// <summary>
        /// 提交人
        /// </summary>
        [XmlElement("submitter")]
        public OpenApiPersonSaDTO Submitter { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        [XmlElement("up_load_time")]
        public string UpLoadTime { get; set; }
    }
}
