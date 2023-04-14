using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBenefitMultibundleConsultResponse.
    /// </summary>
    public class AlipayOpenMiniBenefitMultibundleConsultResponse : AopResponse
    {
        /// <summary>
        /// 券内容
        /// </summary>
        [XmlArray("op_benefit_data_list")]
        [XmlArrayItem("op_benefit_data_v_o")]
        public List<OpBenefitDataVO> OpBenefitDataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
