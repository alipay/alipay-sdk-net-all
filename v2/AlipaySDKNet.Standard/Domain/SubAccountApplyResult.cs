using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountApplyResult Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountApplyResult : AopObject
    {
        /// <summary>
        /// 支付宝虚拟账号，也称2088账号，在业财/结算系统内作为pid字段,并作为财资子户申请的依据
        /// </summary>
        [XmlElement("alipay_virtual_id")]
        public string AlipayVirtualId { get; set; }
    }
}
