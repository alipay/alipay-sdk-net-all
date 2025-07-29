using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupcontrolBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupcontrolBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 广告屏蔽记录列表
        /// </summary>
        [XmlElement("group_control_list")]
        public GroupControlRecordVO GroupControlList { get; set; }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示条数，最大展示50条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 广告屏蔽记录总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
