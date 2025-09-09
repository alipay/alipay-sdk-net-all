using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNdeviceWorkUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNdeviceWorkUnbindModel : AopObject
    {
        /// <summary>
        /// 碰一下设备sn标识
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型，主要描述当前碰一下设备类型，如N6E
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务主键ID，用来保证绑定操作重试操作下幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 关联设备sn唯一标识
        /// </summary>
        [XmlElement("related_device_sn")]
        public string RelatedDeviceSn { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
