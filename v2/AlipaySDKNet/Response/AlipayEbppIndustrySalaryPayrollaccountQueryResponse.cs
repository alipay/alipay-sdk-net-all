using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryPayrollaccountQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryPayrollaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// Map<String,String>,JSON BASE64Encode key=子户用途,  value=子户外标. PAY_ROLL@888888123 表示在888888123母户下开通代发子户
        /// </summary>
        [XmlElement("acct_map")]
        public string AcctMap { get; set; }

        /// <summary>
        /// 开户场景
        /// </summary>
        [XmlElement("acct_type")]
        public string AcctType { get; set; }

        /// <summary>
        /// 代发商户的商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 代发商户名字
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 响应收付通加签的xml，通过base64Encode编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
