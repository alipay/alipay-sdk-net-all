using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 物料申请单号，即SO单号
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
