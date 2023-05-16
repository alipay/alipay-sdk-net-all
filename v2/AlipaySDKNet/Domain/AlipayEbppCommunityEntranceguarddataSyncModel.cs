using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityEntranceguarddataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityEntranceguarddataSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝小区编码
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 如果开门失败，记录失败原因（sdk错误码）
        /// </summary>
        [XmlElement("enter_error_message")]
        public string EnterErrorMessage { get; set; }

        /// <summary>
        /// 开门门记录编号
        /// </summary>
        [XmlElement("enter_record_id")]
        public string EnterRecordId { get; set; }

        /// <summary>
        /// 开门结果，1成功，0失败
        /// </summary>
        [XmlElement("enter_result")]
        public string EnterResult { get; set; }

        /// <summary>
        /// 开门时间
        /// </summary>
        [XmlElement("enter_time")]
        public string EnterTime { get; set; }

        /// <summary>
        /// 加密后的支付宝用户id
        /// </summary>
        [XmlElement("user_id_encrypt")]
        public string UserIdEncrypt { get; set; }
    }
}
