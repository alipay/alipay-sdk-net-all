using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthParticipantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthParticipantInfo : AopObject
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [XmlElement("participant_biz_param")]
        public ParticipantBizParam ParticipantBizParam { get; set; }

        /// <summary>
        /// 主体ID，更具主体类型确定
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 主体类型： ALIPAY_LOGON_ID: 登陆号 ALIPAY_OPEN_ID：支付宝openId ALIPAY_USER_ID：支付宝账号
        /// </summary>
        [XmlElement("participant_id_type")]
        public string ParticipantIdType { get; set; }
    }
}
