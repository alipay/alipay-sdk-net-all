using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMallApplyruleBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMallApplyruleBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商圈mallid，由支付宝侧业务提供
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("rule_scene")]
        public string RuleScene { get; set; }
    }
}
