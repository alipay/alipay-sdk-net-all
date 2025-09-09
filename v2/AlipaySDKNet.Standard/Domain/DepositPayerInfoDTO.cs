using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepositPayerInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DepositPayerInfoDTO : AopObject
    {
        /// <summary>
        /// 描述参与方信息的扩展属性，使用前请与支付宝工程师确认
        /// </summary>
        [XmlElement("ext_info")]
        public RepaymentParticipantExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 参与方的唯一标识。
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的标识类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID  2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式  3、ALIPAY_OPEN_ID：支付宝openid
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 参与方真实姓名，如果非空，将校验收款支付宝账号姓名一致性。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
