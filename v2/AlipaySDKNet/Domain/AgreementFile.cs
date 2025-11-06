using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementFile Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementFile : AopObject
    {
        /// <summary>
        /// 星河协议编号（唯一）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 合同编号（该合同编号为协议生成方生成）
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 协议PDF文件Id 需要通过alipay.open.file.upload，支付宝文件上传接口上传文件，获取对应的file_id（注意，入参内的biz_code传xhcarfinance_instinfo_upload）
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 协议状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签署时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
