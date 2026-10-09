using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleStdOrderFundSubSidyVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleStdOrderFundSubSidyVO : AopObject
    {
        /// <summary>
        /// 营销资金
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 范围：WAIT_PAY待贷款、SUCCESS打款完成、FAILD打款失败
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 百分比单位数值0-100
        /// </summary>
        [XmlElement("percent")]
        public string Percent { get; set; }
    }
}
