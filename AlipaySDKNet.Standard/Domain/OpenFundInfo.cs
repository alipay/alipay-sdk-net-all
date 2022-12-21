using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenFundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenFundInfo : AopObject
    {
        /// <summary>
        /// 预算
        /// </summary>
        [XmlElement("budget")]
        public OpenBudget Budget { get; set; }

        /// <summary>
        /// 封顶金额
        /// </summary>
        [XmlElement("ceiling_amount")]
        public long CeilingAmount { get; set; }

        /// <summary>
        /// 账号描述：登录号、userId
        /// </summary>
        [XmlElement("display_account")]
        public string DisplayAccount { get; set; }

        /// <summary>
        /// 资金账号：余额userId、余额宝userId、集分宝预算库ID、子模板(支付宝补贴模板)Id
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 资金模式 该值为内部计算获得，不允许上游设置
        /// </summary>
        [XmlElement("fund_mode")]
        public string FundMode { get; set; }

        /// <summary>
        /// 出资方, 默认有资金部分平台出资, 无资金部分商户出资
        /// </summary>
        [XmlElement("fund_provider")]
        public string FundProvider { get; set; }

        /// <summary>
        /// 资金比率
        /// </summary>
        [XmlElement("fund_ratio")]
        public long FundRatio { get; set; }

        /// <summary>
        /// 出资账号关联id，当出资账号是资金方案时，该属性值为资金关系组id
        /// </summary>
        [XmlElement("fund_related_id")]
        public string FundRelatedId { get; set; }

        /// <summary>
        /// 资金源出资类型，走通兑模式传兑换源资产种类码
        /// </summary>
        [XmlElement("fund_source_type")]
        public string FundSourceType { get; set; }

        /// <summary>
        /// 资金类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 单间商品封顶优惠金额
        /// </summary>
        [XmlElement("item_ceiling_amount")]
        public long ItemCeilingAmount { get; set; }

        /// <summary>
        /// 单间商品商户补贴优惠取整模式
        /// </summary>
        [XmlElement("item_merchant_subsidy_rounding_mode")]
        public string ItemMerchantSubsidyRoundingMode { get; set; }

        /// <summary>
        /// 微账务账号: 对于特殊场景需要保存 b类账户的微账务账号 例如yebcore
        /// </summary>
        [XmlElement("minitrans_account")]
        public string MinitransAccount { get; set; }

        /// <summary>
        /// 集分宝预算库：运营积分场景，fundAccount为商户id，系统会自动补充集分宝预算库
        /// </summary>
        [XmlElement("point_budget_code")]
        public string PointBudgetCode { get; set; }

        /// <summary>
        /// 充值操作冻结码
        /// </summary>
        [XmlElement("recharge_freeze_code")]
        public string RechargeFreezeCode { get; set; }

        /// <summary>
        /// 出资充值模式
        /// </summary>
        [XmlElement("recharge_type")]
        public string RechargeType { get; set; }

        /// <summary>
        /// 退款资金账号：对于比较特殊的场景 支出和收入不是一个账号的 使用refundAccount作为退款账号
        /// </summary>
        [XmlElement("refund_account")]
        public string RefundAccount { get; set; }

        /// <summary>
        /// 退款优先级
        /// </summary>
        [XmlElement("refund_funding_priority")]
        public long RefundFundingPriority { get; set; }
    }
}
