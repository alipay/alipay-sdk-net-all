using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopProductPriceModifyResult Data Structure.
    /// </summary>
    [Serializable]
    public class ShopProductPriceModifyResult : AopObject
    {
        /// <summary>
        /// 当前门店处理失败时返回的业务错误码。
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 当前门店处理失败的具体原因。
        /// </summary>
        [XmlElement("error_reason")]
        public string ErrorReason { get; set; }

        /// <summary>
        /// 服务商请求中传入的外部门店 ID。
        /// </summary>
        [XmlElement("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// 企业码内部的门店 ID。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
