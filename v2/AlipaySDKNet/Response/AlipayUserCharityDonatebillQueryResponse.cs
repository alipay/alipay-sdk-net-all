using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCharityDonatebillQueryResponse.
    /// </summary>
    public class AlipayUserCharityDonatebillQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户在公益捐赠项目的流水信息列表
        /// </summary>
        [XmlArray("donate_bill_list")]
        [XmlArrayItem("donate_bill_info")]
        public List<DonateBillInfo> DonateBillList { get; set; }

        /// <summary>
        /// 分页查询的当前页数，与入参page_num一致
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每批分页查询的数量，与入参page_size一致
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 用户当日捐赠成功的总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
