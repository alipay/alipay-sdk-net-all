using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementFullInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementFullInfo : AopObject
    {
        /// <summary>
        /// 星河侧唯一协议编号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 版本，默认1.0
        /// </summary>
        [XmlElement("agreement_version")]
        public string AgreementVersion { get; set; }

        /// <summary>
        /// 协议富文本
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 支付宝开放平台的文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 签署信息
        /// </summary>
        [XmlArray("sign_info_list")]
        [XmlArrayItem("carfin_sign_info")]
        public List<CarfinSignInfo> SignInfoList { get; set; }

        /// <summary>
        /// 代表协议签署的状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签署时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 协议标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
