using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountQueryRequest : AopObject
    {
        /// <summary>
        /// 支付宝虚拟账号，也称2088账号，由每个sourceUid申请得到一个
        /// </summary>
        [XmlElement("alipay_virtual_id")]
        public string AlipayVirtualId { get; set; }
    }
}
