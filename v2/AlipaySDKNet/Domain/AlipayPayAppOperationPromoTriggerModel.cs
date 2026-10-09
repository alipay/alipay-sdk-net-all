using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppOperationPromoTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppOperationPromoTriggerModel : AopObject
    {
        /// <summary>
        /// 手机号MD5加密结果
        /// </summary>
        [XmlElement("app_mobile")]
        public string AppMobile { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 设备号，设备号类型由device_type字段指定
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备号类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 运营信息，用于串联多阶段营销。
        /// </summary>
        [XmlElement("pay_operation_info")]
        public string PayOperationInfo { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 触发方式
        /// </summary>
        [XmlElement("trigger_type")]
        public string TriggerType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
