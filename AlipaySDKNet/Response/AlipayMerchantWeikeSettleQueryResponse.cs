using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantWeikeSettleQueryResponse.
    /// </summary>
    public class AlipayMerchantWeikeSettleQueryResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 分页查询页号，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询页大小，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 用户任务列表
        /// </summary>
        [XmlArray("user_task_views")]
        [XmlArrayItem("user_task_view")]
        public List<UserTaskView> UserTaskViews { get; set; }
    }
}
