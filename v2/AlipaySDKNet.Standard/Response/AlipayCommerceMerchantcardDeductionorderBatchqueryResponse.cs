using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardDeductionorderBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardDeductionorderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回内容
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("deduction_order_info")]
        public List<DeductionOrderInfo> Content { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
