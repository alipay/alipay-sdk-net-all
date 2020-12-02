using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainTwcUserinfoMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainTwcUserinfoMatchModel : AopObject
    {
        /// <summary>
        /// 支付宝的UID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 移动号码hash后的字符串
        /// </summary>
        [XmlElement("call_no_hash")]
        public string CallNoHash { get; set; }

        /// <summary>
        /// 注册使用的用户名
        /// </summary>
        [XmlElement("unify_no")]
        public string UnifyNo { get; set; }

        /// <summary>
        /// 名字证件号对应的sha256的hash值
        /// </summary>
        [XmlElement("unify_no_hash")]
        public string UnifyNoHash { get; set; }
    }
}
