using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletBillhistoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletBillhistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单详情列表
        /// </summary>
        [XmlArray("bills")]
        [XmlArrayItem("bill")]
        public List<Bill> Bills { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询数据的总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
