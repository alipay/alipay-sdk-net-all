using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplatemsgMaketingBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniTemplatemsgMaketingBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 投放详情列表
        /// </summary>
        [XmlArray("marketing_delivery_detail_list")]
        [XmlArrayItem("marketing_delivery_detail")]
        public List<MarketingDeliveryDetail> MarketingDeliveryDetailList { get; set; }

        /// <summary>
        /// 投放详情总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
