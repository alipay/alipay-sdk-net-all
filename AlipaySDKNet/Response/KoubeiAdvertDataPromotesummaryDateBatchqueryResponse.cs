using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotesummaryDateBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotesummaryDateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑客推广日期维度汇总数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("promote_date_model")]
        public List<PromoteDateModel> Data { get; set; }
    }
}
