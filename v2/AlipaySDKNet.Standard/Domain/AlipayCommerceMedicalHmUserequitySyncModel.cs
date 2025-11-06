using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmUserequitySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmUserequitySyncModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 支付宝给出固定枚举值，参考：证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 关联保司侧的登录账号
        /// </summary>
        [XmlElement("company_account")]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// 权益下发场景必填，支付宝后台生成后给出固定编码值
        /// </summary>
        [XmlElement("equity_package_code")]
        public string EquityPackageCode { get; set; }

        /// <summary>
        /// 标识唯一一次权益下发
        /// </summary>
        [XmlElement("out_biz_serial_no")]
        public string OutBizSerialNo { get; set; }

        /// <summary>
        /// 外部对接系统的用户ID
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 约定合作项目标识，支付宝后台生成后给出固定编码值
        /// </summary>
        [XmlElement("project_tag")]
        public string ProjectTag { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("tel_no")]
        public string TelNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
