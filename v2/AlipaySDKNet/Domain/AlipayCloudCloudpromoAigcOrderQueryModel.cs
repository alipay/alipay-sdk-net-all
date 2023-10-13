using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAigcOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAigcOrderQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝内部订单id，唯一
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
