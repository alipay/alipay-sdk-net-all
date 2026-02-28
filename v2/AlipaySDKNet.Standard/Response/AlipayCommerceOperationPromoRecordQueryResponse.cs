using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoRecordQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoRecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("act_sign_up_record")]
        public List<ActSignUpRecord> Records { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
