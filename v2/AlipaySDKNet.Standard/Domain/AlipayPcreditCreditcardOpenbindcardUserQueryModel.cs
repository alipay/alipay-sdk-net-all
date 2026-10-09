using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditCreditcardOpenbindcardUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditCreditcardOpenbindcardUserQueryModel : AopObject
    {
        /// <summary>
        /// 外部绑卡活动业务编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// MD5加密身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// MD5加密手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
