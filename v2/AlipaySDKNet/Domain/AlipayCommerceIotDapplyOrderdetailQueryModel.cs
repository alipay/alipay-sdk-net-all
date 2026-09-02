using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyOrderdetailQueryModel : AopObject
    {
        /// <summary>
        /// 设备申请业务订单号（业务唯一键）
        /// </summary>
        [XmlElement("order_biz_id")]
        public string OrderBizId { get; set; }
    }
}
