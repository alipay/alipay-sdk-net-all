using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityDeviceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpromoactivityDeviceModifyModel : AopObject
    {
        /// <summary>
        /// 用户在支付侧参加设备活动的id，服务商在拉取 leads 时获得。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 更换活动设备的业务时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 原活动设备sn编号
        /// </summary>
        [XmlElement("source_dvc_sn")]
        public string SourceDvcSn { get; set; }

        /// <summary>
        /// 目标活动设备sn编号
        /// </summary>
        [XmlElement("target_dvc_sn")]
        public string TargetDvcSn { get; set; }
    }
}
