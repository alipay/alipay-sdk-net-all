using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpromoactivityEffectModel : AopObject
    {
        /// <summary>
        /// 用户在支付侧参加设备活动的id，服务商在拉取 leads 时获得。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 生效用户活动任务的业务时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 用户参与活动的设备编号
        /// </summary>
        [XmlElement("dvc_sn")]
        public string DvcSn { get; set; }
    }
}
