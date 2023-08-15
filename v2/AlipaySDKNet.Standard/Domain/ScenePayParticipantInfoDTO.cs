using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenePayParticipantInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScenePayParticipantInfoDTO : AopObject
    {
        /// <summary>
        /// 参与者业务参数
        /// </summary>
        [XmlElement("participant_biz_param")]
        public ScenePayParticipantBizParamDTO ParticipantBizParam { get; set; }

        /// <summary>
        /// 根据participant_id_type填写对应值 ● participant_id_type=ALIPAY_USER_ID时，填写支付宝UID ● participant_id_type=ALIPAY_LOGON_ID时，填写登录号，且name填写真实姓名 ● participant_id_type=ALIPAY_OPEN_ID时，填写支付宝openid
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// ● ALIPAY_USER_ID -- 支付宝UID ● ALIPAY_LOGON_ID -- 支付宝登录号 ● ALIPAY_OPNE_ID -- 支付宝openId
        /// </summary>
        [XmlElement("participant_id_type")]
        public string ParticipantIdType { get; set; }
    }
}
