using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallOrderConsultResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallOrderConsultResponse : AopResponse
    {
        /// <summary>
        /// 订单号列表
        /// </summary>
        [XmlArray("order_id_list")]
        [XmlArrayItem("string")]
        public List<string> OrderIdList { get; set; }

        /// <summary>
        /// 采购单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
