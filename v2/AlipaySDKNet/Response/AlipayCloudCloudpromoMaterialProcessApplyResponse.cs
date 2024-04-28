using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMaterialProcessApplyResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMaterialProcessApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部订单id，唯一
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，原样返回
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
