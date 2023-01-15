using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PariticipantDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PariticipantDTO : AopObject
    {
        /// <summary>
        /// 参与方的唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的标识类型，目前支持如下类型：  1.ALIPAY_USER_ID：支付宝的会员ID 2.ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 参与方名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
