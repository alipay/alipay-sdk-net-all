using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsRightsorderDetailQueryResponse.
    /// </summary>
    public class AlipayInsRightsorderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单状态，SUCCESS、ASSET_CONSUMED 表示积分完成扣减后的状态；FAILED、ASSET_ROLLBACK、INIT表示积分未扣减状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
