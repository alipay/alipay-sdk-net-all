using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNdeviceWorkBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNdeviceWorkBindModel : AopObject
    {
        /// <summary>
        /// 碰一下设备SN标识
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 备类型，主要描述当前碰一下设备类型，如N6E
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备作业记录附件
        /// </summary>
        [XmlArray("device_work_attachment")]
        [XmlArrayItem("n_device_work_attach")]
        public List<NDeviceWorkAttach> DeviceWorkAttachment { get; set; }

        /// <summary>
        /// 设备作业位置信息
        /// </summary>
        [XmlElement("device_work_position")]
        public NDeviceWorkPosition DeviceWorkPosition { get; set; }

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
