using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceBillReverseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfacceptanceBillReverseModel : AopObject
    {
        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 业财逆向账单受理
        /// </summary>
        [XmlElement("reverse_bill_acceptance")]
        public GFAOpenAPIReverseBillAcceptance ReverseBillAcceptance { get; set; }
    }
}
