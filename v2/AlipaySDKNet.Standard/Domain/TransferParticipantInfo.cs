using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferParticipantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransferParticipantInfo : AopObject
    {
        /// <summary>
        /// 参与方扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public ParticipantExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 参与方的身份标识，具体的取值需要和identity_type制定的类型对应的取值匹配。
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的身份类型，有限枚举，指定说明参与方身份标识具体的取值类型。
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 参与方主体真实姓名，如果非空，将校验收款支付宝账号姓名一致性。当identity_type=ALIPAY_LOGON_ID时，本字段必填。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
