using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoBillableInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class PoBillableInfoDto : AopObject
    {
        /// <summary>
        /// 是否海外
        /// </summary>
        [XmlElement("is_abroad")]
        public bool IsAbroad { get; set; }

        /// <summary>
        /// 是否当前采购人
        /// </summary>
        [XmlElement("is_current_buyer")]
        public bool IsCurrentBuyer { get; set; }

        /// <summary>
        /// 采购订单编号
        /// </summary>
        [XmlElement("po_no")]
        public string PoNo { get; set; }

        /// <summary>
        /// 收件人信息
        /// </summary>
        [XmlElement("receive_info")]
        public ReceiveInfoDto ReceiveInfo { get; set; }
    }
}
