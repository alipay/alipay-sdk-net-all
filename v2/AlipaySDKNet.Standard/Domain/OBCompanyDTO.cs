using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OBCompanyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OBCompanyDTO : AopObject
    {
        /// <summary>
        /// 合同列表
        /// </summary>
        [XmlArray("contract_list")]
        [XmlArrayItem("o_b_contract_d_t_o")]
        public List<OBContractDTO> ContractList { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 企业实体名称
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 维保校验状态
        /// </summary>
        [XmlElement("ma_check_status")]
        public long MaCheckStatus { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 工单权限
        /// </summary>
        [XmlElement("work_order_permission")]
        public bool WorkOrderPermission { get; set; }
    }
}
