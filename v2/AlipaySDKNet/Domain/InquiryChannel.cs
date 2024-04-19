using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InquiryChannel Data Structure.
    /// </summary>
    [Serializable]
    public class InquiryChannel : AopObject
    {
        /// <summary>
        /// 问诊医生排班信息列表
        /// </summary>
        [XmlArray("inquiry_doctor_shift_case_list")]
        [XmlArrayItem("inquiry_doctor_shift_case_data")]
        public List<InquiryDoctorShiftCaseData> InquiryDoctorShiftCaseList { get; set; }

        /// <summary>
        /// 问诊方式：IMAGE_INQUIRY(图文问诊)/PHONE_INQUIRY(电话问诊)/VEDIO_INQUIRY(视频问诊)
        /// </summary>
        [XmlElement("inquiry_mode")]
        public string InquiryMode { get; set; }

        /// <summary>
        /// 问诊价格（中间必须有小数点，后面两位小数），单位元
        /// </summary>
        [XmlElement("inquiry_price")]
        public string InquiryPrice { get; set; }

        /// <summary>
        /// 问诊类型
        /// </summary>
        [XmlElement("inquiry_type")]
        public string InquiryType { get; set; }

        /// <summary>
        /// 问诊方式对应服务链接
        /// </summary>
        [XmlElement("inquiry_url")]
        public string InquiryUrl { get; set; }

        /// <summary>
        /// 是否为预约制 若不填，则默认为否
        /// </summary>
        [XmlElement("register_flag")]
        public bool RegisterFlag { get; set; }
    }
}
