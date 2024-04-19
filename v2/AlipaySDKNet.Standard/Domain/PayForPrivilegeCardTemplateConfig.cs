using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateConfig Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegeCardTemplateConfig : AopObject
    {
        /// <summary>
        /// 卡模板的辅助信息项列表
        /// </summary>
        [XmlArray("auxiliary_item_list")]
        [XmlArrayItem("pay_for_privilege_card_template_auxiliary_item")]
        public List<PayForPrivilegeCardTemplateAuxiliaryItem> AuxiliaryItemList { get; set; }

        /// <summary>
        /// 卡模板头部设置
        /// </summary>
        [XmlElement("header")]
        public PayForPrivilegeCardTemplateHeaderConfig Header { get; set; }

        /// <summary>
        /// 卡模板的操作项列表
        /// </summary>
        [XmlArray("operation_item_list")]
        [XmlArrayItem("pay_for_privilege_card_template_operation_item")]
        public List<PayForPrivilegeCardTemplateOperationItem> OperationItemList { get; set; }

        /// <summary>
        /// 二级区域列表
        /// </summary>
        [XmlArray("secondary_item_list")]
        [XmlArrayItem("pay_for_privilege_card_template_secondary_item")]
        public List<PayForPrivilegeCardTemplateSecondaryItem> SecondaryItemList { get; set; }
    }
}
