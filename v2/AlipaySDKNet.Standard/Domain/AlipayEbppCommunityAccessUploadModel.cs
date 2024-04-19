using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityAccessUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityAccessUploadModel : AopObject
    {
        /// <summary>
        /// 小区code
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
        /// 进门记录编号
        /// </summary>
        [XmlElement("enter_record_id")]
        public string EnterRecordId { get; set; }

        /// <summary>
        /// 进门结果，1成功，0失败
        /// </summary>
        [XmlElement("enter_success")]
        public string EnterSuccess { get; set; }

        /// <summary>
        /// 进门时间
        /// </summary>
        [XmlElement("enter_time")]
        public string EnterTime { get; set; }

        /// <summary>
        /// 用户id（加密后）
        /// </summary>
        [XmlElement("user_id_encrypt")]
        public string UserIdEncrypt { get; set; }
    }
}
