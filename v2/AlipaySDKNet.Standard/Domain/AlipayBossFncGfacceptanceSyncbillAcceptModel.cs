using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceSyncbillAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfacceptanceSyncbillAcceptModel : AopObject
    {
        /// <summary>
        /// 业财账单受理模型
        /// </summary>
        [XmlElement("bill_acceptance")]
        public GFAOpenAPIBillAcceptance BillAcceptance { get; set; }

        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 是否测试模式（走影子链路）。否：真实资金入账；是：不正式入账，一般用于压测或校验。若不填则默认否，即正式入账。
        /// </summary>
        [XmlElement("test_mode")]
        public bool TestMode { get; set; }
    }
}
