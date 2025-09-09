using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPromoInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPromoInfoVO : AopObject
    {
        /// <summary>
        /// 商家优惠详情
        /// </summary>
        [XmlElement("merchant_promo_detail")]
        public RentMerchantPromoDetailInfoVO MerchantPromoDetail { get; set; }

        /// <summary>
        /// 商家优惠汇总，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_total_amount")]
        public string MerchantTotalAmount { get; set; }

        /// <summary>
        /// 订单金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单优惠后金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("order_promo_sale_amount")]
        public string OrderPromoSaleAmount { get; set; }

        /// <summary>
        /// 平台优惠详情
        /// </summary>
        [XmlElement("platform_promo_detail")]
        public RentPlatformPromoDetailInfoVO PlatformPromoDetail { get; set; }

        /// <summary>
        /// 平台优惠汇总，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_total_amount")]
        public string PlatformTotalAmount { get; set; }

        /// <summary>
        /// 分期阶段优惠详情
        /// </summary>
        [XmlArray("stage_promo_detail_list")]
        [XmlArrayItem("rent_stage_promo_detail_info_v_o")]
        public List<RentStagePromoDetailInfoVO> StagePromoDetailList { get; set; }

        /// <summary>
        /// 优惠总金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
