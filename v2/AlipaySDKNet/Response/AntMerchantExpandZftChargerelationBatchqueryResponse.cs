using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandZftChargerelationBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandZftChargerelationBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 记账关系信息数据
        /// </summary>
        [XmlArray("charge_relation_infos")]
        [XmlArrayItem("charge_relation_info")]
        public List<ChargeRelationInfo> ChargeRelationInfos { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认page_size=10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
