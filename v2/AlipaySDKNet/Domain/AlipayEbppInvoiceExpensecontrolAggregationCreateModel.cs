using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolAggregationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolAggregationCreateModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 聚合关系名称 特殊说明：敏感词校验
        /// </summary>
        [XmlElement("aggregation_name")]
        public string AggregationName { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控规则ID列表
        /// </summary>
        [XmlArray("standard_id_list")]
        [XmlArrayItem("string")]
        public List<string> StandardIdList { get; set; }
    }
}
