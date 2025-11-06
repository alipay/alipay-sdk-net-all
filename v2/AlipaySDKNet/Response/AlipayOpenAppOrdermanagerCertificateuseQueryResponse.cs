using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOrdermanagerCertificateuseQueryResponse.
    /// </summary>
    public class AlipayOpenAppOrdermanagerCertificateuseQueryResponse : AopResponse
    {
        /// <summary>
        /// 核销明细列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("certificate_use_info_d_t_o")]
        public List<CertificateUseInfoDTO> Data { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 按查询条件筛选后的总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
