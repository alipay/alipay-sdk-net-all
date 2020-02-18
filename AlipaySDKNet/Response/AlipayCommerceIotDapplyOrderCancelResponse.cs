using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderCancelResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderCancelResponse : AopResponse
    {
        /// <summary>
        /// 物料申请单号
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
