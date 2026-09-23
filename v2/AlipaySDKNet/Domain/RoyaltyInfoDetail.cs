using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoyaltyInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyInfoDetail : AopObject
    {
        /// <summary>
        /// 分账错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 分账错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分账类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 分账状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 分账成功时该字段有值
        /// </summary>
        [XmlElement("trans_finish_dt")]
        public string TransFinishDt { get; set; }

        /// <summary>
        /// 分账转入账号
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }
    }
}
