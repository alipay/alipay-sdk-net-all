using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcApprovalConfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcApprovalConfigModifyModel : AopObject
    {
        /// <summary>
        /// 审批单配置项
        /// </summary>
        [XmlArray("approval_config_list")]
        [XmlArrayItem("approval_configm_item_d_t_o")]
        public List<ApprovalConfigmItemDTO> ApprovalConfigList { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 二级场景
        /// </summary>
        [XmlElement("expense_type_sub_category")]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 一级场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
