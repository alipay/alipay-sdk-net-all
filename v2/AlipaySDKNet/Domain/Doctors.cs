using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Doctors Data Structure.
    /// </summary>
    [Serializable]
    public class Doctors : AopObject
    {
        /// <summary>
        /// 权威认证
        /// </summary>
        [XmlElement("authority")]
        public string Authority { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 医生用户名
        /// </summary>
        [XmlElement("doctor_user_name")]
        public string DoctorUserName { get; set; }

        /// <summary>
        /// 医院
        /// </summary>
        [XmlElement("hospital")]
        public string Hospital { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话问诊价格
        /// </summary>
        [XmlElement("phone_price")]
        public string PhonePrice { get; set; }

        /// <summary>
        /// 电话回复时间
        /// </summary>
        [XmlElement("phone_reply_time")]
        public string PhoneReplyTime { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [XmlElement("professional")]
        public string Professional { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }

        /// <summary>
        /// 图文问诊价格
        /// </summary>
        [XmlElement("text_price")]
        public string TextPrice { get; set; }

        /// <summary>
        /// 图文回复时间
        /// </summary>
        [XmlElement("text_reply_time")]
        public string TextReplyTime { get; set; }

        /// <summary>
        /// 黄页地址
        /// </summary>
        [XmlElement("yellow_page_url")]
        public string YellowPageUrl { get; set; }
    }
}
