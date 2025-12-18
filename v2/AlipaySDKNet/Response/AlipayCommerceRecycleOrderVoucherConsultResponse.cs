using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrderVoucherConsultResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrderVoucherConsultResponse : AopResponse
    {
        /// <summary>
        /// 券信息
        /// </summary>
        [XmlElement("voucher_info")]
        public RecycleVoucherInfo VoucherInfo { get; set; }
    }
}
