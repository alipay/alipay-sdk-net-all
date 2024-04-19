using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMallRulelimitBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMallRulelimitBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈商场付多门店业务规则限制对象信息集合
        /// </summary>
        [XmlArray("limit_list")]
        [XmlArrayItem("rule_limit_content_ext_d_t_o")]
        public List<RuleLimitContentExtDTO> LimitList { get; set; }

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
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
