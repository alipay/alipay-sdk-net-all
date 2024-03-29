using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DefaultSettleRule Data Structure.
    /// </summary>
    [Serializable]
    public class DefaultSettleRule : AopObject
    {
        /// <summary>
        /// 默认结算目标。当默认结算类型为bankCard时填写银行卡卡号，其值需在进件填写的结算银行卡范围内；当默认结算类型为alipayAccount时填写支付宝账号登录号，其值需在进件填写的结算支付宝账号范围内。
        /// </summary>
        [XmlElement("default_settle_target")]
        public string DefaultSettleTarget { get; set; }

        /// <summary>
        /// 默认结算类型，可选值有bankCard/alipayAccount。bankCard表示结算到银行卡；alipayAccount表示结算到支付宝账号
        /// </summary>
        [XmlElement("default_settle_type")]
        public string DefaultSettleType { get; set; }
    }
}
