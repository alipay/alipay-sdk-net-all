using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHotelLockerOrgSyncResponse.
    /// </summary>
    public class AlipayCommerceHotelLockerOrgSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝机构唯一ID
        /// </summary>
        [XmlElement("alipay_org_id")]
        public string AlipayOrgId { get; set; }
    }
}
