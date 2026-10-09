using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WithdrawClauseDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WithdrawClauseDetailDTO : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 资产主体对象
        /// </summary>
        [XmlElement("trans_out_principal")]
        public WitnessPrincipalDTO TransOutPrincipal { get; set; }

        /// <summary>
        /// 提现主体
        /// </summary>
        [XmlElement("withdraw_principal")]
        public WithdrawPrincipalDTO WithdrawPrincipal { get; set; }
    }
}
