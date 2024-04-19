using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceApplyUploadResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceApplyUploadResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁订单号
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
