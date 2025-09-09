using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorAlipayAccountModel Data Structure.
    /// </summary>
    [Serializable]
    public class HonorAlipayAccountModel : AopObject
    {
        /// <summary>
        /// 账号 (掩码)
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 优先级：从小到大，小优先级高
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 姓名 (掩码)
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }
    }
}
