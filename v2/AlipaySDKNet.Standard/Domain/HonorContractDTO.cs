using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorContractDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorContractDTO : AopObject
    {
        /// <summary>
        /// 合同文本
        /// </summary>
        [XmlElement("contract_content")]
        public string ContractContent { get; set; }

        /// <summary>
        /// 合同id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 是否默认勾选，1：勾选；0：不勾选
        /// </summary>
        [XmlElement("default_checked")]
        public long DefaultChecked { get; set; }

        /// <summary>
        /// 是否强制阅读，0：默认不强制；1：强制用户阅读
        /// </summary>
        [XmlElement("force_read")]
        public long ForceRead { get; set; }

        /// <summary>
        /// 是否需要上滑阅读全部，0：不需要；1：需要上滑阅读全部
        /// </summary>
        [XmlElement("read_all")]
        public long ReadAll { get; set; }

        /// <summary>
        /// 强读时长（秒）
        /// </summary>
        [XmlElement("read_time")]
        public long ReadTime { get; set; }

        /// <summary>
        /// 类型, 1-URL, 2-html, 3-pdf
        /// </summary>
        [XmlElement("text_type")]
        public long TextType { get; set; }
    }
}
