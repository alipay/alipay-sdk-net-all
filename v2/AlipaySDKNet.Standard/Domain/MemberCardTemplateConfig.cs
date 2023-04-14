using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardTemplateConfig Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardTemplateConfig : AopObject
    {
        /// <summary>
        /// 附加项列表
        /// </summary>
        [XmlArray("auxiliary_item_list")]
        [XmlArrayItem("member_card_template_auxiliary_item")]
        public List<MemberCardTemplateAuxiliaryItem> AuxiliaryItemList { get; set; }

        /// <summary>
        /// 会员卡头部信息
        /// </summary>
        [XmlElement("header")]
        public MemberCardTemplateHeaderConfig Header { get; set; }

        /// <summary>
        /// 操作项列表
        /// </summary>
        [XmlArray("operation_item_list")]
        [XmlArrayItem("member_card_template_operation_item")]
        public List<MemberCardTemplateOperationItem> OperationItemList { get; set; }

        /// <summary>
        /// 二级区域列表
        /// </summary>
        [XmlArray("secondary_item_list")]
        [XmlArrayItem("member_card_template_secondary_item")]
        public List<MemberCardTemplateSecondaryItem> SecondaryItemList { get; set; }
    }
}
