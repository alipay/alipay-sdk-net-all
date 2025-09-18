using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ThirdActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ThirdActivityInfo : AopObject
    {
        /// <summary>
        /// 活动模版id
        /// </summary>
        [XmlElement("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 出资的资金类型 MONEY-余额 MERCHANT_POINT-积分
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 活动支持的期数
        /// </summary>
        [XmlArray("install_num_list")]
        [XmlArrayItem("number")]
        public List<long> InstallNumList { get; set; }

        /// <summary>
        /// 金额上限,人民币元（CNY）
        /// </summary>
        [XmlElement("max_money_limit")]
        public string MaxMoneyLimit { get; set; }

        /// <summary>
        /// 金额下限,人民币元（CNY）
        /// </summary>
        [XmlElement("min_money_limit")]
        public string MinMoneyLimit { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态 EFFECTIVE有效 INEFFECTIVE无效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 贴息场景 ALL代表全场贴息  SPECIFIED_RULES 代表指定规则
        /// </summary>
        [XmlElement("subsidy_scope")]
        public string SubsidyScope { get; set; }
    }
}
