using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAreaplatformMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAreaplatformMsgSendModel : AopObject
    {
        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital")]
        public string Hospital { get; set; }

        /// <summary>
        /// 医院ID类型
        /// </summary>
        [XmlElement("hospital_id_type")]
        public string HospitalIdType { get; set; }

        /// <summary>
        /// 医院ID
        /// </summary>
        [XmlElement("hospital_register_id")]
        public string HospitalRegisterId { get; set; }

        /// <summary>
        /// 消息参数列表
        /// </summary>
        [XmlArray("msg_arg_list")]
        [XmlArrayItem("medical_area_platform_msg_send_arg")]
        public List<MedicalAreaPlatformMsgSendArg> MsgArgList { get; set; }

        /// <summary>
        /// 外部消息id
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 就诊人姓名
        /// </summary>
        [XmlElement("patient")]
        public string Patient { get; set; }

        /// <summary>
        /// 模板码，支付宝侧定义
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("user_card_type")]
        public string UserCardType { get; set; }
    }
}
