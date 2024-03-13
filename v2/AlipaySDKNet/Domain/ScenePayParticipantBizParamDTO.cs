using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenePayParticipantBizParamDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScenePayParticipantBizParamDTO : AopObject
    {
        /// <summary>
        /// 由各业务场景定义，具体参考场景解决方案接入文档
        /// </summary>
        [XmlElement("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// 配合外部身份证件类型
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 外部签约号
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 外部身份证件类型
        /// </summary>
        [XmlElement("external_cert_type")]
        public string ExternalCertType { get; set; }

        /// <summary>
        /// 外部卡号
        /// </summary>
        [XmlElement("out_card_no")]
        public string OutCardNo { get; set; }

        /// <summary>
        /// 申请用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
