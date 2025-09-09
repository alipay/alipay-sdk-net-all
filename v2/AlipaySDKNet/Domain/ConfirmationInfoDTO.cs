using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConfirmationInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ConfirmationInfoDTO : AopObject
    {
        /// <summary>
        /// 酒店确认号
        /// </summary>
        [XmlElement("confirm_num")]
        public string ConfirmNum { get; set; }

        /// <summary>
        /// 已确认:CONFIRMED 确认失败：CONFIRMED_FAIL 确认中：CONFIRING
        /// </summary>
        [XmlElement("confirm_result")]
        public string ConfirmResult { get; set; }

        /// <summary>
        /// 订单确认时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 售卖房型是否为“立即确认”房型：True-是；False-否；
        /// </summary>
        [XmlElement("instant_confirm")]
        public bool InstantConfirm { get; set; }
    }
}
