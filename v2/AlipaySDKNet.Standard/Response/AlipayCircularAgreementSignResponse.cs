using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCircularAgreementSignResponse.
    /// </summary>
    public class AlipayCircularAgreementSignResponse : AopResponse
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
        /// 账户所属openid
        /// </summary>
        [XmlElement("relation_openid")]
        public string RelationOpenid { get; set; }

        /// <summary>
        /// 账户所属uid
        /// </summary>
        [XmlElement("relation_uid")]
        public string RelationUid { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 代扣页面链接，与sign_channel关联
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
