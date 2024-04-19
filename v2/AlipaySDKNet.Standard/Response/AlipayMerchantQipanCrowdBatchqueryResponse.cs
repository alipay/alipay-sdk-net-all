using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商家自定义人群列表
        /// </summary>
        [XmlArray("crowd_list")]
        [XmlArrayItem("qipan_merchant_crowd")]
        public List<QipanMerchantCrowd> CrowdList { get; set; }

        /// <summary>
        /// 返回查询结果的总条数
        /// </summary>
        [XmlElement("total_number")]
        public string TotalNumber { get; set; }
    }
}
