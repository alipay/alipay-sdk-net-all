using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardUserinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardUserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 医保电子凭证授权码
        /// </summary>
        [XmlElement("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 授权码对应的医保电子凭证持卡人证件号
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 授权码对应的医保电子凭证持卡人的证件类型
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 授权码对应的医保电子凭证持卡人的姓名
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
    }
}
