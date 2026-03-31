using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Mail Data Structure.
    /// </summary>
    [Serializable]
    public class Mail : AopObject
    {
        /// <summary>
        /// 快递员姓名
        /// </summary>
        [XmlElement("courier_name")]
        public string CourierName { get; set; }

        /// <summary>
        /// 快递员电话号码
        /// </summary>
        [XmlElement("courier_phone_num")]
        public string CourierPhoneNum { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// 邮递时间
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }
    }
}
