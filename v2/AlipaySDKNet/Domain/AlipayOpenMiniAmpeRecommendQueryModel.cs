using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeRecommendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeRecommendQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景，由支付宝统一分配，用于指定推荐的内容。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// AMPE设备ID，用于标记唯一的一台设备。
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 运行时的设备、卡片信息
        /// </summary>
        [XmlElement("device_info")]
        public AmpeDeviceInfo DeviceInfo { get; set; }

        /// <summary>
        /// 支付宝用户openId 当前字段已废弃(通过accessToken获取userId)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// AMPE产品ID，在开放平台注册后可获取。
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 请求流水号。
        /// </summary>
        [XmlElement("req_no")]
        public string ReqNo { get; set; }

        /// <summary>
        /// 支付宝用户userId 当前字段已废弃(通过accessToken获取userId)
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
