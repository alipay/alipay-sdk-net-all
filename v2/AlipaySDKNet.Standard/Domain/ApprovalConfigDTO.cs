using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalConfigDTO : AopObject
    {
        /// <summary>
        /// 审批单配置项
        /// </summary>
        [XmlArray("approval_config_list")]
        [XmlArrayItem("approval_configm_item_d_t_o")]
        public List<ApprovalConfigmItemDTO> ApprovalConfigList { get; set; }

        /// <summary>
        /// 配置ID
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// OWNER_PAY：个垫
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// OVERTIME：加班
        /// </summary>
        [XmlElement("scene_category")]
        public string SceneCategory { get; set; }

        /// <summary>
        /// TAKE_AWAY：外卖
        /// </summary>
        [XmlElement("scene_sub_category")]
        public string SceneSubCategory { get; set; }
    }
}
