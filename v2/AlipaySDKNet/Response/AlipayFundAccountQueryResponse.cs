using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountQueryResponse.
    /// </summary>
    public class AlipayFundAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户可用余额，单位元，精确到小数点后两位。
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 场景余额模式外标卡信息
        /// </summary>
        [XmlElement("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }

        /// <summary>
        /// 当前支付宝账户的实时冻结余额
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }
    }
}
