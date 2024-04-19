using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingDataBillBatchqueryResponse.
    /// </summary>
    public class AnttechMorseMarketingDataBillBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 查询账单的数据对象列表
        /// </summary>
        [XmlArray("bills")]
        [XmlArrayItem("data_bill_result")]
        public List<DataBillResult> Bills { get; set; }

        /// <summary>
        /// 查询结果统计的总条数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 分页查询当前页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询结果数据中每页几条数据量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
