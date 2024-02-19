using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudDevopsDeviceConditionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudDevopsDeviceConditionQueryModel : AopObject
    {
        /// <summary>
        /// 空闲设备
        /// </summary>
        [XmlElement("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 渠道用户id
        /// </summary>
        [XmlElement("channel_user_id")]
        public string ChannelUserId { get; set; }

        /// <summary>
        /// 渠道用户标记
        /// </summary>
        [XmlElement("channel_user_tag")]
        public string ChannelUserTag { get; set; }

        /// <summary>
        /// 过滤平台
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 独享设备
        /// </summary>
        [XmlElement("private_device")]
        public bool PrivateDevice { get; set; }

        /// <summary>
        /// 正常状态设备
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 可以远程真机使用
        /// </summary>
        [XmlElement("vnc")]
        public bool Vnc { get; set; }
    }
}
