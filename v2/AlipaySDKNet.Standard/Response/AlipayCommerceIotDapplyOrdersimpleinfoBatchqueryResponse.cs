using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrdersimpleinfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrdersimpleinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 批量下单后系统会根据批量文件每行生成一个设备申请单，该单号对应这个申请单的业务订单号(业务主键)。
        /// </summary>
        [XmlArray("order_biz_ids")]
        [XmlArrayItem("string")]
        public List<string> OrderBizIds { get; set; }
    }
}
