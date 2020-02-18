using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportWorldCarddataApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportWorldCarddataApplyResponse : AopResponse
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 生码时间戳
        /// </summary>
        [XmlElement("card_timestamp")]
        public long CardTimestamp { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 请求失败时的错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否首次使用
        /// </summary>
        [XmlElement("first_use_time")]
        public bool FirstUseTime { get; set; }

        /// <summary>
        /// 请求失败时返回的子错误码信息
        /// </summary>
        [XmlElement("sub_error_code")]
        public string SubErrorCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 基础响应信息
        /// </summary>
        [XmlElement("world_base_rpc_response_info")]
        public WorldBaseRPCResponseInfo WorldBaseRpcResponseInfo { get; set; }

        /// <summary>
        /// 密钥数据
        /// </summary>
        [XmlElement("world_offline_data_info")]
        public WorldOfflineDataInfo WorldOfflineDataInfo { get; set; }
    }
}
