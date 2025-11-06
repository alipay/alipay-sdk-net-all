using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformPageinfoGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalHzreferralformPageinfoGetResponse : AopResponse
    {
        /// <summary>
        /// 转诊单分页的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 转诊单分页列表的每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 转诊分页列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("referral_form_page_v_o")]
        public List<ReferralFormPageVO> Records { get; set; }

        /// <summary>
        /// 转诊单列表的总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
