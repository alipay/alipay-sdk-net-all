using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGasInfoGroupcouponQueryResponse.
    /// </summary>
    public class AlipayCommerceGasInfoGroupcouponQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码,不填写默认查第1页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数量,不填写默认10条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 用户劵信息
        /// </summary>
        [XmlArray("voucher_infos")]
        [XmlArrayItem("voucher_info_v_o")]
        public List<VoucherInfoVO> VoucherInfos { get; set; }
    }
}
