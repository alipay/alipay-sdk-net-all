using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMallApplyruleBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMallApplyruleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 规则列表
        /// </summary>
        [XmlArray("apply_rules")]
        [XmlArrayItem("mall_pay_group_apply_rule")]
        public List<MallPayGroupApplyRule> ApplyRules { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数 和入参保持一致
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总规则数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
