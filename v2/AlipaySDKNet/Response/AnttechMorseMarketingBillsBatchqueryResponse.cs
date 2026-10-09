using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingBillsBatchqueryResponse.
    /// </summary>
    public class AnttechMorseMarketingBillsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 交易账单列表
        /// </summary>
        [XmlArray("bills")]
        [XmlArrayItem("bill_result")]
        public List<BillResult> Bills { get; set; }

        /// <summary>
        /// 业务唯一标识，用于双方排查问题
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 查询结果统计的总条数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 分页查询当前页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }
    }
}
