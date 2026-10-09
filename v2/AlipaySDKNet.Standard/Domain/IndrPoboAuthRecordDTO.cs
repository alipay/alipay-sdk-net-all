using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrPoboAuthRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrPoboAuthRecordDTO : AopObject
    {
        /// <summary>
        /// 刷卡 auth 金额
        /// </summary>
        [XmlElement("auth_amount")]
        public IndrMoneyDTO AuthAmount { get; set; }

        /// <summary>
        /// 刷卡 auth 结果
        /// </summary>
        [XmlElement("auth_result")]
        public string AuthResult { get; set; }

        /// <summary>
        /// 渠道响应信息
        /// </summary>
        [XmlElement("channel_message")]
        public string ChannelMessage { get; set; }

        /// <summary>
        /// auth 记录创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商户类型
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 单次 auth 记录唯一交易 id
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
