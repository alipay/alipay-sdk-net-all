using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceAccountingAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfacceptanceAccountingAcceptModel : AopObject
    {
        /// <summary>
        /// 核算受理
        /// </summary>
        [XmlElement("accounting_acceptance")]
        public GFAOpenAPIAccountingAcceptance AccountingAcceptance { get; set; }

        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }
    }
}
