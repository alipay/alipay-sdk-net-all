using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcCommandSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcCommandSendModel : AopObject
    {
        /// <summary>
        /// 业务发生时间；对应etc_switch_status的不同状态，当etc_switch_status=OPEN，为设备开启时间，etc_switch_status=CLOSE为设备关闭时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 阐明本次指令下发原因
        /// </summary>
        [XmlElement("command_reason")]
        public string CommandReason { get; set; }

        /// <summary>
        /// 支付宝企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// ETC设备开关状态
        /// </summary>
        [XmlElement("etc_switch_status")]
        public string EtcSwitchStatus { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
