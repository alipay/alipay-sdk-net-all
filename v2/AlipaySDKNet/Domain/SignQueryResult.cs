using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class SignQueryResult : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 绑定结果
        /// </summary>
        [XmlElement("bind_results")]
        public string BindResults { get; set; }

        /// <summary>
        /// 冻结金额，单位：CNY
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 签约时间，yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }
    }
}
