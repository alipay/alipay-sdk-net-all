using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepaymentParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentParticipant : AopObject
    {
        /// <summary>
        /// 零工卡专用金还款到卡银行卡扩展参数
        /// </summary>
        [XmlElement("bankcard_ext_info")]
        public RepaymentBankcardExtInfo BankcardExtInfo { get; set; }

        /// <summary>
        /// 参与方关联的扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public RepaymentParticipantExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 参与方标识，根据不同的标识类型填写对应的标识ID。
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方账号标识类型，支持： 1. ALIPAY_LOGON_ID 2. ALIPAY_USER_ID 3. ALIPAY_OPEN_ID 4. BANK_CARD_NO
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 参与方名称，默认可选。部分identity_type下name必须提供。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
