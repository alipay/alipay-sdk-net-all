using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceSignresultQueryResponse.
    /// </summary>
    public class AlipayEbppInstserviceSignresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝签约协议id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 用户签约的户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 签约机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 外部协议号
        /// </summary>
        [XmlElement("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 签约状态：sign：已签约，unsign：已解约，not_sign：未签约，signing： 签约中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
