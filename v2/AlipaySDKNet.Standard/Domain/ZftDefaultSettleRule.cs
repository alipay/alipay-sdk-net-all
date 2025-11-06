using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZftDefaultSettleRule Data Structure.
    /// </summary>
    [Serializable]
    public class ZftDefaultSettleRule : AopObject
    {
        /// <summary>
        /// 默认结算目标。当默认结算类型为alipayAccount时填写支付宝账号登录号，其值需在进件填写的结算支付宝账号范围内。
        /// </summary>
        [XmlElement("default_settle_target")]
        public string DefaultSettleTarget { get; set; }

        /// <summary>
        /// 默认结算类型，默认alipayAccount
        /// </summary>
        [XmlElement("default_settle_type")]
        public string DefaultSettleType { get; set; }
    }
}
