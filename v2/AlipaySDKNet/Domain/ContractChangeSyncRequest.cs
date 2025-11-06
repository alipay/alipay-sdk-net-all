using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractChangeSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ContractChangeSyncRequest : AopObject
    {
        /// <summary>
        /// 文件信息
        /// </summary>
        [XmlElement("attachment_file_info")]
        public AttachmentFileInfo AttachmentFileInfo { get; set; }

        /// <summary>
        /// 用于定义具体的业务场景，由财务结算进行统一定义与分配，使用前需咨询财务结算获取对应业务场景定义，例如合同一致性业务场景填：CONTRACT_CONSISTENCY
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// * 变更类型，上游根据实际变更场景填写，例如上游如果是新增合同可尝试填写ADD
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 使用方的合同号，使用方如实填写即可，无需咨询财务结算
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同文件的全名，需要包含后缀名
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 用于定义合同所属源头，由财务结算统一动态生成并发挥，使用前需咨询财务结算获取对应业务的合同源，例如置业合同源可填写为PROPERTY_ZHIYE
        /// </summary>
        [XmlElement("contract_source")]
        public string ContractSource { get; set; }

        /// <summary>
        /// 描述当前业务方所属业务域，大多数情况下需要使用财务结算分配的核心层业务身份，例如：置业：BID215008008077000
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 元数据描述
        /// </summary>
        [XmlArray("meta_datas")]
        [XmlArrayItem("meta_data")]
        public List<MetaData> MetaDatas { get; set; }

        /// <summary>
        /// 同步合同的模式，上游实际场景填写即可
        /// </summary>
        [XmlElement("sync_mode")]
        public string SyncMode { get; set; }

        /// <summary>
        /// 用于定义是哪个系统发送的请求，使用方如实填写即可，无需咨询财务结算
        /// </summary>
        [XmlElement("sys_source")]
        public string SysSource { get; set; }
    }
}
