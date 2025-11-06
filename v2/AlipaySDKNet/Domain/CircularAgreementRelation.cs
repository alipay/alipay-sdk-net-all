using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CircularAgreementRelation Data Structure.
    /// </summary>
    [Serializable]
    public class CircularAgreementRelation : AopObject
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
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
