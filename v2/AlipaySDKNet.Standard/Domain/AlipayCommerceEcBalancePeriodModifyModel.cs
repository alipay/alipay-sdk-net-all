using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcBalancePeriodModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcBalancePeriodModifyModel : AopObject
    {
        /// <summary>
        /// 共同账户id - 适用于在企业码小程序创建的共同账户，和agreement_no搭配使用
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 月账单账期
        /// </summary>
        [XmlElement("bill_day")]
        public long BillDay { get; set; }

        /// <summary>
        /// 企业ID - 适用于在企业码PC端创建的企业账号
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
