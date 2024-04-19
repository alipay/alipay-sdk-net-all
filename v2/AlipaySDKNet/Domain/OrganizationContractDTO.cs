using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrganizationContractDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrganizationContractDTO : AopObject
    {
        /// <summary>
        /// 合同id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合同标题
        /// </summary>
        [XmlElement("contract_title")]
        public string ContractTitle { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 维保结束时间
        /// </summary>
        [XmlElement("ma_end_time")]
        public string MaEndTime { get; set; }

        /// <summary>
        /// 维保开始时间
        /// </summary>
        [XmlElement("ma_start_time")]
        public string MaStartTime { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }
    }
}
