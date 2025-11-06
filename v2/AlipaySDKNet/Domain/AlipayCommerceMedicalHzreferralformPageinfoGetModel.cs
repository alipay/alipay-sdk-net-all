using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformPageinfoGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHzreferralformPageinfoGetModel : AopObject
    {
        /// <summary>
        /// 医生的身份信息
        /// </summary>
        [XmlElement("doctor_cert_no")]
        public string DoctorCertNo { get; set; }

        /// <summary>
        /// 转诊单分页列表的查询分页页数，第n页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 转诊单分页列表的分页大小，即n条记录为一页
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 转诊单的来源，"HZ_XH"为杭州来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 转诊单状态
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
