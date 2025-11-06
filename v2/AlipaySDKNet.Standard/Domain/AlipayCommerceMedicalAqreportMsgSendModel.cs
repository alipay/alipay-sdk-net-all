using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAqreportMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAqreportMsgSendModel : AopObject
    {
        /// <summary>
        /// AQ报告查询
        /// </summary>
        [XmlElement("biz_principal")]
        public string BizPrincipal { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 院区名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 消息创建时间，时间格式为：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("msg_create_time")]
        public string MsgCreateTime { get; set; }

        /// <summary>
        /// 消息修改时间，时间格式为：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("msg_modified_time")]
        public string MsgModifiedTime { get; set; }

        /// <summary>
        /// 商户订单id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [XmlElement("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报告数量
        /// </summary>
        [XmlElement("report_num")]
        public long ReportNum { get; set; }

        /// <summary>
        /// 报告出具时间
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }

        /// <summary>
        /// 报告来源
        /// </summary>
        [XmlElement("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// 模板码，支付宝侧定义
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }

        /// <summary>
        /// 用户证件号
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 用户身份类型
        /// </summary>
        [XmlElement("user_card_type")]
        public string UserCardType { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("user_phone_no")]
        public string UserPhoneNo { get; set; }
    }
}
