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
        /// 优惠力度最大的单张券
        /// </summary>
        [XmlElement("best_voucher")]
        public UserAvailableVoucher BestVoucher { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("user_available_voucher_list")]
        [XmlArrayItem("user_available_voucher")]
        public List<UserAvailableVoucher> UserAvailableVoucherList { get; set; }
    }
}
