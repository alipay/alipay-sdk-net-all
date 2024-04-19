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
        /// 外部用户的证件号码，若证件类型为身份证，那么填入身份证号码即可
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 外部用户的证件类型，例如身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 国家局医保一码付场景使用，用于标识签约渠道id
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 外部卡号
        /// </summary>
        [XmlElement("out_card_no")]
        public string OutCardNo { get; set; }

        /// <summary>
        /// 外部用户的姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
