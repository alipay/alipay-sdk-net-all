using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeEnterpriseDelegationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeEnterpriseDelegationQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 预下单ID，如果是预下单场景传预下单ID,如果是创单场景可以直接传递交易号
        /// </summary>
        [XmlElement("prepay_id")]
        public string PrepayId { get; set; }
    }
}
