using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseRegisterapplyQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseRegisterapplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页容量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 注册申请信息列表
        /// </summary>
        [XmlArray("register_apply_info_list")]
        [XmlArrayItem("register_apply_info_d_t_o")]
        public List<RegisterApplyInfoDTO> RegisterApplyInfoList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
