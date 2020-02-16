using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotSnApplyBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotSnApplyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 申请单列表
        /// </summary>
        [XmlArray("apply_list")]
        [XmlArrayItem("sn_apply_info")]
        public List<SnApplyInfo> ApplyList { get; set; }

        /// <summary>
        /// 历史sn生成成功的操作总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
