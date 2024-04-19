using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityUserBatchqueryvoucherResponse.
    /// </summary>
    public class AlipayMarketingActivityUserBatchqueryvoucherResponse : AopResponse
    {
        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 用户券实例
        /// </summary>
        [XmlArray("user_voucher_infos")]
        [XmlArrayItem("user_voucher_info")]
        public List<UserVoucherInfo> UserVoucherInfos { get; set; }
    }
}
