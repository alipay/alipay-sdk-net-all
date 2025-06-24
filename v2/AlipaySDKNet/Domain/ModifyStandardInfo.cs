using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModifyStandardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ModifyStandardInfo : AopObject
    {
        /// <summary>
        /// 要添加的条件列表
        /// </summary>
        [XmlArray("add_condition_list")]
        [XmlArrayItem("standard_condition_info")]
        public List<StandardConditionInfo> AddConditionList { get; set; }

        /// <summary>
        /// 当前规则可使用的其他资产来源信息
        /// </summary>
        [XmlElement("asset_share_source_info")]
        public AssetShareSourceInfo AssetShareSourceInfo { get; set; }

        /// <summary>
        /// 消费模式
        /// </summary>
        [XmlElement("consume_mode")]
        public string ConsumeMode { get; set; }

        /// <summary>
        /// 待删除的条件id列表
        /// </summary>
        [XmlArray("delete_condition_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeleteConditionIdList { get; set; }

        /// <summary>
        /// 修改的条件列表
        /// </summary>
        [XmlArray("modify_condition_list")]
        [XmlArrayItem("standard_condition_info")]
        public List<StandardConditionInfo> ModifyConditionList { get; set; }

        /// <summary>
        /// 使用规则绑定的开票规则id
        /// </summary>
        [XmlElement("open_rule_id")]
        public string OpenRuleId { get; set; }

        /// <summary>
        /// 支付策略 当笔消费金额大于规则可用余额时，用于控制支付策略。COMBINATION表示支持因公资产和个人资产组合支付，PERSONAL表示整单个人支付。
        /// </summary>
        [XmlElement("payment_policy")]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 个人收款码转账是否支持因公付。可选值：0（不支持）、1（支持）
        /// </summary>
        [XmlElement("personal_qrcode_mode")]
        public long PersonalQrcodeMode { get; set; }

        /// <summary>
        /// 使用规则描述
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 修改的使用规则id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }

        /// <summary>
        /// 使用规则名称
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
