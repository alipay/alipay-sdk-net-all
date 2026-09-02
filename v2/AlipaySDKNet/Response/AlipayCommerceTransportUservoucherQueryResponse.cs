using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportUservoucherQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportUservoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("user_available_voucher_list")]
        [XmlArrayItem("user_available_voucher")]
        public List<UserAvailableVoucher> UserAvailableVoucherList { get; set; }
    }
}
