using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinOrgexpressCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinOrgexpressCreateModel : AopObject
    {
        /// <summary>
        /// 预约上门时间
        /// </summary>
        [XmlElement("appointment_time")]
        public string AppointmentTime { get; set; }

        /// <summary>
        /// 坐席下单：ORG_SEATS 客户下单： ORG_CUST
        /// </summary>
        [XmlElement("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 抵押单号
        /// </summary>
        [XmlElement("mortgage_no")]
        public string MortgageNo { get; set; }

        /// <summary>
        /// 收件人信息
        /// </summary>
        [XmlElement("receiver_info")]
        public XhExpressPostInfo ReceiverInfo { get; set; }

        /// <summary>
        /// 寄件人信息
        /// </summary>
        [XmlElement("sender_info")]
        public XhExpressPostInfo SenderInfo { get; set; }
    }
}
