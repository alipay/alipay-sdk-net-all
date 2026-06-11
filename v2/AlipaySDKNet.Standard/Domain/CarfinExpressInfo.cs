using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinExpressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinExpressInfo : AopObject
    {
        /// <summary>
        /// 快递员姓名
        /// </summary>
        [XmlElement("courier_name")]
        public string CourierName { get; set; }

        /// <summary>
        /// 快递员手机号
        /// </summary>
        [XmlElement("courier_phone")]
        public string CourierPhone { get; set; }

        /// <summary>
        /// 寄件人信息
        /// </summary>
        [XmlElement("sender_info")]
        public XhExpressPostInfo SenderInfo { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
