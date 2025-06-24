using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsLinkGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsLinkGetModel : AopObject
    {
        /// <summary>
        /// 物流产品配置生成，用于标识物流业务场景以及执行的动作
        /// </summary>
        [XmlElement("logistics_biz_scene_action")]
        public string LogisticsBizSceneAction { get; set; }

        /// <summary>
        /// 商户传入请求端名称，用于区分商户请求来源
        /// </summary>
        [XmlElement("merchant_request_source")]
        public string MerchantRequestSource { get; set; }

        /// <summary>
        /// 物流系统生成，用于标识物流商户驿站唯一编码
        /// </summary>
        [XmlElement("merchant_station_code")]
        public string MerchantStationCode { get; set; }

        /// <summary>
        /// 商户传入驿站小件员唯一标识
        /// </summary>
        [XmlElement("merchant_station_expressman_id")]
        public string MerchantStationExpressmanId { get; set; }

        /// <summary>
        /// 商户传入驿站名称
        /// </summary>
        [XmlElement("merchant_station_name")]
        public string MerchantStationName { get; set; }

        /// <summary>
        /// 商户传入驿站门店唯一标识
        /// </summary>
        [XmlElement("merchant_station_shop_id")]
        public string MerchantStationShopId { get; set; }
    }
}
