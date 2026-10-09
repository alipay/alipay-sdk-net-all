using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QipanGreyBlackCrowdUser Data Structure.
    /// </summary>
    [Serializable]
    public class QipanGreyBlackCrowdUser : AopObject
    {
        /// <summary>
        /// 用户的支付宝账号通过加密类型加密后的结果
        /// </summary>
        [XmlElement("encrypt_alipay_id")]
        public string EncryptAlipayId { get; set; }

        /// <summary>
        /// 用户身份证号码通过加密类型加密后的结果
        /// </summary>
        [XmlElement("encrypt_identity_card_id")]
        public string EncryptIdentityCardId { get; set; }

        /// <summary>
        /// 用户的手机号通过加密类型加密后的结果
        /// </summary>
        [XmlElement("encrypt_mobile_id")]
        public string EncryptMobileId { get; set; }

        /// <summary>
        /// 本字段用于标识用户信息SHA256加密类型
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 用户入库灰黑产时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("storage_time")]
        public string StorageTime { get; set; }

        /// <summary>
        /// 用户的交易订单号，不需要加密
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户黑名单类型，多种类型请用英文逗号隔开，如：FRAUD,DISPUTE。 枚举值： FRAUD：疑似欺诈 DISPUTE：案件纠纷 OVERDUE：租赁逾期 OTHER：其他黑名单
        /// </summary>
        [XmlElement("user_tags")]
        public string UserTags { get; set; }
    }
}
