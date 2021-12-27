using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationUserBenefitBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceOperationUserBenefitBatchqueryResponse : AopResponse
    {
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
        /// 总长度
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 权益列表
        /// </summary>
        [XmlElement("user_benefit_info_list")]
        public UserBenefitInfo UserBenefitInfoList { get; set; }
    }
}
