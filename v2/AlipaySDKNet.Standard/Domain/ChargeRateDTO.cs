using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeRateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeRateDTO : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 收费方式
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 固定费用
        /// </summary>
        [XmlElement("fix_rate")]
        public string FixRate { get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 下限
        /// </summary>
        [XmlElement("min_amount")]
        public string MinAmount { get; set; }

        /// <summary>
        /// 费率类型
        /// </summary>
        [XmlElement("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// 费率
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }
    }
}
