using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankStudyprofileModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCreditbankStudyprofileModifyModel : AopObject
    {
        /// <summary>
        /// 学分银行用户ID
        /// </summary>
        [XmlElement("cb_id")]
        public string CbId { get; set; }

        /// <summary>
        /// 获得证书信息
        /// </summary>
        [XmlArray("certificate_experience")]
        [XmlArrayItem("credit_bank_certificate_experience")]
        public List<CreditBankCertificateExperience> CertificateExperience { get; set; }

        /// <summary>
        /// 职业培训成果数量
        /// </summary>
        [XmlElement("certificate_num")]
        public long CertificateNum { get; set; }

        /// <summary>
        /// 渠道，默认值：shcreditbank(上海学分银行)
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 成绩档案信息
        /// </summary>
        [XmlArray("credit")]
        [XmlArrayItem("credit_bank_credit")]
        public List<CreditBankCredit> Credit { get; set; }

        /// <summary>
        /// 学历教育成果数量
        /// </summary>
        [XmlElement("credit_num")]
        public long CreditNum { get; set; }

        /// <summary>
        /// 培训经历
        /// </summary>
        [XmlArray("training")]
        [XmlArrayItem("credit_bank_training")]
        public List<CreditBankTraining> Training { get; set; }

        /// <summary>
        /// 培训经历成果数量
        /// </summary>
        [XmlElement("training_num")]
        public long TrainingNum { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
