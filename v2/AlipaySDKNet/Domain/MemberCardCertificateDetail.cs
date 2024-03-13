using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardCertificateDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardCertificateDetail : AopObject
    {
        /// <summary>
        /// 兑换跳转链接（长链接），其中已包含了凭证token唯一信息，如其他用户获取到链接后也可进行兑换（未开启身份校验）
        /// </summary>
        [XmlElement("direct_url")]
        public string DirectUrl { get; set; }

        /// <summary>
        /// 凭证生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 凭证过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 凭证唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户兑换开通凭证的唯一业务流水号
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 凭证状态： P：可使用 S：使用完毕 R：已撤销 注：P状态不代表一定可用，需要或可能进行使用时间以及用户身份的校验
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 凭证可兑换的目标，如用户兑换的会员卡商品skuId
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// 用户兑换凭证可使用的次数，一般为1次，默认为1次
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 兑换跳转链接，其中已包含了凭证token唯一信息，如其他用户获取到链接后也可进行兑换（未开启身份校验）
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 凭证已使用次数
        /// </summary>
        [XmlElement("usage_count")]
        public long UsageCount { get; set; }

        /// <summary>
        /// 用户兑换凭证时的手机号信息，仅支持中国大陆11位手机号码
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }

        /// <summary>
        /// 凭证的值，如凭证兑换码
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// 使用凭证的用户支付宝账户校验模式，默认不进行校验 UID：按凭证同步时传入的user_id校验用户支付宝登录账户的uid MOBILE：按凭证同步时传入的user_mobile校验用户支付宝登录账户的注册手机号
        /// </summary>
        [XmlElement("verify_mode")]
        public string VerifyMode { get; set; }
    }
}
