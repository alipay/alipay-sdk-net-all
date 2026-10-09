using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodSettleorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodSettleorderQueryModel : AopObject
    {
        /// <summary>
        /// 应付结算单查询
        /// </summary>
        [XmlElement("ap_settle_order_query_order")]
        public ApSettleOrderQueryOrder ApSettleOrderQueryOrder { get; set; }
    }
}
