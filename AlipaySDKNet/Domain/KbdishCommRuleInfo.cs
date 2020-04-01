using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishCommRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCommRuleInfo : AopObject
    {
        /// <summary>
        /// 口碑菜品id/口碑skuId/规格的specId,需要和type一一对应
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 绑定的组id
        /// </summary>
        [XmlElement("comm_group_id")]
        public string CommGroupId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 口碑定制组明细id
        /// </summary>
        [XmlElement("group_detail_id")]
        public string GroupDetailId { get; set; }

        /// <summary>
        /// 商户的id,可不传
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 规则id,口碑系统生成,  如果是新增操作，设置为空.  如果是修改，可以根据rule_id来修改，也可以根据 biz_id+rule_type+comm_group_id+group_detail_id 来操作
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 口碑规则定制类型  DISH_PROPERTY_GROUP：菜品属性组 SKU_MATERIAL_GROUP：sku加料组 DISH_PROPERTY_DETAIL：菜品属性明细 SKU_MATERIAL_DETAIL：sku加料明细 DISH_SPEC_GROUP:菜品规格组 DISH_SPEC_DETAIL:菜品规格组标签
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [XmlArray("show_rule_list")]
        [XmlArrayItem("kbdish_comm_rule_show_info")]
        public List<KbdishCommRuleShowInfo> ShowRuleList { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;del 删除
        /// </summary>
        [XmlElement("syn_type")]
        public string SynType { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
