using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyApplyorderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyApplyorderCancelModel : AopObject
    {
        /// <summary>
        /// 设备申请业务订单号
        /// </summary>
        [XmlElement("order_biz_id")]
        public string OrderBizId { get; set; }
    }
}
