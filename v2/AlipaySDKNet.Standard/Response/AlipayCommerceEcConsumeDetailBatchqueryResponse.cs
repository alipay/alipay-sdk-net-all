using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcConsumeDetailBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcConsumeDetailBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 账单信息列表
        /// </summary>
        [XmlArray("consume_info_list")]
        [XmlArrayItem("ec_consume_info")]
        public List<EcConsumeInfo> ConsumeInfoList { get; set; }

        /// <summary>
        /// 当期页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 当期页记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
