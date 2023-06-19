using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RealAmountRatioIncentiveRule Data Structure.
    /// </summary>
    [Serializable]
    public class RealAmountRatioIncentiveRule : AopObject
    {
        /// <summary>
        /// 允许发放激励的交易最小金额限制，单位元
        /// </summary>
        [XmlElement("amount_min")]
        public string AmountMin { get; set; }

        /// <summary>
        /// 淘客任务默认的分佣比率
        /// </summary>
        [XmlElement("default_ratio")]
        public string DefaultRatio { get; set; }

        /// <summary>
        /// 淘客任务最大激励金额，单位元
        /// </summary>
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 淘客任务最大的激励笔数
        /// </summary>
        [XmlElement("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// 淘客任务明星用户集合
        /// </summary>
        [XmlArray("star_uid_list")]
        [XmlArrayItem("star_uid_amount_ratio_d_t_o")]
        public List<StarUidAmountRatioDTO> StarUidList { get; set; }
    }
}
