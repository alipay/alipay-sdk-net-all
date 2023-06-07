using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCertificateUserBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCertificateUserBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 凭证信息列表
        /// </summary>
        [XmlArray("certificate_info_list")]
        [XmlArrayItem("certificate_query_info")]
        public List<CertificateQueryInfo> CertificateInfoList { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
