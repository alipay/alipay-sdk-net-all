using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceReceiptBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceReceiptBatchqueryModel : AopObject
    {
        /// <summary>
        /// 请求等级 normal 返回每个订单的能量g数，默认值。 detail 额外返回每个订单对应环保类行的能量g数，对应 energy_generated。
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 外部订单号列表，最多支持10个
        /// </summary>
        [XmlArray("out_biz_no_list")]
        [XmlArrayItem("string")]
        public List<string> OutBizNoList { get; set; }
    }
}
