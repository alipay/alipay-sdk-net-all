using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCircularAgreementSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCircularAgreementSignModel : AopObject
    {
        /// <summary>
        /// 绑定的收款钱包信息Id
        /// </summary>
        [XmlElement("bind_wallet_id")]
        public string BindWalletId { get; set; }

        /// <summary>
        /// 代扣关系支付类型
        /// </summary>
        [XmlElement("bind_wallet_type")]
        public string BindWalletType { get; set; }

        /// <summary>
        /// 扣款支付宝账户
        /// </summary>
        [XmlElement("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 扣款账户所属openid
        /// </summary>
        [XmlElement("relation_openid")]
        public string RelationOpenid { get; set; }

        /// <summary>
        /// 扣款账户所属uid
        /// </summary>
        [XmlElement("relation_uid")]
        public string RelationUid { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 签约方式，默认QRCODE
        /// </summary>
        [XmlElement("sign_channel")]
        public string SignChannel { get; set; }
    }
}
