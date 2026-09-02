using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DelegationParams Data Structure.
    /// </summary>
    [Serializable]
    public class DelegationParams : AopObject
    {
        /// <summary>
        /// 对AI付代买委托意图做描述
        /// </summary>
        [XmlElement("delegation_desc")]
        public string DelegationDesc { get; set; }

        /// <summary>
        /// 委托业务场景
        /// </summary>
        [XmlElement("delegation_scene")]
        public string DelegationScene { get; set; }

        /// <summary>
        /// 描述代买委托
        /// </summary>
        [XmlElement("delegation_tag")]
        public string DelegationTag { get; set; }

        /// <summary>
        /// 代理授权周期任务参数
        /// </summary>
        [XmlElement("delegation_task_params")]
        public DelegationTaskParams DelegationTaskParams { get; set; }

        /// <summary>
        /// 外部商户AI付代买委托id，用于委托申请成功后区分不同的委托任务
        /// </summary>
        [XmlElement("external_delegation_id")]
        public string ExternalDelegationId { get; set; }

        /// <summary>
        /// 外部交易号列表
        /// </summary>
        [XmlElement("external_tradeno_list")]
        public string ExternalTradenoList { get; set; }

        /// <summary>
        /// 首次扣款时间
        /// </summary>
        [XmlElement("first_deduct_time")]
        public string FirstDeductTime { get; set; }

        /// <summary>
        /// 商品 SKU 信息
        /// </summary>
        [XmlElement("goods_sku_info")]
        public string GoodsSkuInfo { get; set; }

        /// <summary>
        /// AI付代买委托总限额，币种为人民币，单位为元
        /// </summary>
        [XmlElement("max_total_amount")]
        public string MaxTotalAmount { get; set; }

        /// <summary>
        /// AI委托授权单次限额，币种为人民币，金额为元
        /// </summary>
        [XmlElement("quota_amount")]
        public string QuotaAmount { get; set; }

        /// <summary>
        /// AI付代买委托总次数
        /// </summary>
        [XmlElement("times_limit")]
        public string TimesLimit { get; set; }

        /// <summary>
        /// AI付代买委托总次数 当前字段已废弃(拼写错误，迁移至times_limit字段)
        /// </summary>
        [XmlElement("times_timit")]
        public string TimesTimit { get; set; }

        /// <summary>
        /// AI付代买委托结束时间
        /// </summary>
        [XmlElement("validity_end_time")]
        public string ValidityEndTime { get; set; }

        /// <summary>
        /// AI付代买委托任务起始时间
        /// </summary>
        [XmlElement("validity_start_time")]
        public string ValidityStartTime { get; set; }
    }
}
