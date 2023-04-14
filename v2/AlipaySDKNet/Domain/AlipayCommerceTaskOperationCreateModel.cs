using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTaskOperationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTaskOperationCreateModel : AopObject
    {
        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 任务周期数值
        /// </summary>
        [XmlElement("cycle")]
        public string Cycle { get; set; }

        /// <summary>
        /// 任务周期类型
        /// </summary>
        [XmlElement("cycle_type")]
        public string CycleType { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展内容，主要满足文案等个性化的定制以及额外的配置项需求
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务场景，如茶饮：CY，景区：JQ
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 默认结算到品牌
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 任务适用门店范围类型(MULTI_SHOP-多门店任务，SINGLE_SHOP-单门店任务)
        /// </summary>
        [XmlElement("shop_scope_type")]
        public string ShopScopeType { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 启动类型
        /// </summary>
        [XmlElement("startup_type")]
        public string StartupType { get; set; }

        /// <summary>
        /// 任务指标数值
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// 任务指标类型
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 任务监听规则类型，监听范围包括账号(pid_smid)，门店(shop_store)，小程序(appId)： 1. pid_smid_appId - 账号+小程序 2. pid_smid_shop_store - 账号+门店 3. pid_smid - 账号 4. pid_smid_shop_store_appId - 账号+门店+小程序
        /// </summary>
        [XmlElement("task_rule_type")]
        public string TaskRuleType { get; set; }

        /// <summary>
        /// 任务类型：ZMGO-芝麻GO活动
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券模版id
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }
    }
}
