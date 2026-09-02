using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderIndflowActionMaintainModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderIndflowActionMaintainModel : AopObject
    {
        /// <summary>
        /// 动作发生时间
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// EXPOSE 曝光/CLICK 点击
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 展位外部ID
        /// </summary>
        [XmlElement("ad_pos_id")]
        public string AdPosId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 供给ID
        /// </summary>
        [XmlElement("supply_id")]
        public string SupplyId { get; set; }
    }
}
