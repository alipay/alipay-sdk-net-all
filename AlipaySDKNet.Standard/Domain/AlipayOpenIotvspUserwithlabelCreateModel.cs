using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspUserwithlabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspUserwithlabelCreateModel : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，枚举支持：IDENTITY_CARD身份证，PASS_PORT护照，STU_NUM学生学号，COMPANY_NUM工号，TAIWAN_CARD台胞证，HK_MC_CARD港澳证件
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 组件编码，该参数与userInfoList配对使用。详见接入指南
        /// </summary>
        [XmlElement("component_out_id")]
        public string ComponentOutId { get; set; }

        /// <summary>
        /// 扩展信息，ISV自定义，如无可为空
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// ISV的PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 标签外标最多5个
        /// </summary>
        [XmlElement("label_out_no")]
        public string LabelOutNo { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
