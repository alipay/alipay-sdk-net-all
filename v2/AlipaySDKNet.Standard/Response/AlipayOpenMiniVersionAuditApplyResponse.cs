using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionAuditApplyResponse.
    /// </summary>
    public class AlipayOpenMiniVersionAuditApplyResponse : AopResponse
    {
        /// <summary>
        /// 是否加速审核 加速：true； 不加速：false
        /// </summary>
        [XmlElement("speed_up")]
        public string SpeedUp { get; set; }

        /// <summary>
        /// 提审加速审核说明
        /// </summary>
        [XmlElement("speed_up_memo")]
        public string SpeedUpMemo { get; set; }
    }
}
