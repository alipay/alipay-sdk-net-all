using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyBkamcAntauthsignConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyBkamcAntauthsignConsultModel : AopObject
    {
        /// <summary>
        /// 客户id，根据custType不同填入不同的值
        /// </summary>
        [XmlElement("cust_id")]
        public string CustId { get; set; }

        /// <summary>
        /// USERID：支付宝2088 LOGINID：支付宝登录id，用来走未授权场景查询2088
        /// </summary>
        [XmlElement("cust_type")]
        public string CustType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }
    }
}
