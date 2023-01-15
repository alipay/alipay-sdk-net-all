using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceSyncbillCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfacceptanceSyncbillCancelModel : AopObject
    {
        /// <summary>
        /// 业财账单受理模型
        /// </summary>
        [XmlElement("bill_acceptance")]
        public GFAOpenAPIReverseBillAcceptance BillAcceptance { get; set; }

        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }
    }
}
