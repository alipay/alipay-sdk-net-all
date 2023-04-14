using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAddressQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseAddressQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 地址列表
        /// </summary>
        [XmlArray("enterprise_address_info_list")]
        [XmlArrayItem("address_info_d_t_o")]
        public List<AddressInfoDTO> EnterpriseAddressInfoList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
