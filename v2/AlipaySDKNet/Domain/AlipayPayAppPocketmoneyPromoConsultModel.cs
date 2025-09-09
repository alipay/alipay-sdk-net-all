using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPocketmoneyPromoConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPocketmoneyPromoConsultModel : AopObject
    {
        /// <summary>
        /// 奖品流水单号，由外部厂商提供，查询时支付宝负责找到对应奖品
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 活动业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 运动步数（单位步）、跳绳数（单位次）等
        /// </summary>
        [XmlElement("biz_value")]
        public string BizValue { get; set; }

        /// <summary>
        /// 设备号，openWatchId，rtos设备可不传
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 兼容设备号，openId
        /// </summary>
        [XmlElement("extra_device_id")]
        public string ExtraDeviceId { get; set; }

        /// <summary>
        /// 操作系统，android，rtos
        /// </summary>
        [XmlElement("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// true-可以发红包奖品，false-跳过红包奖品 (设备历史已发放)
        /// </summary>
        [XmlElement("red_packet_flag")]
        public bool RedPacketFlag { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [XmlElement("solution_vendor")]
        public string SolutionVendor { get; set; }
    }
}
