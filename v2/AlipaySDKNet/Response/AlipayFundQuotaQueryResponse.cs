using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundQuotaQueryResponse.
    /// </summary>
    public class AlipayFundQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 商转新额度单日剩余额度，单位为元，精确到小数点后两位；当product_code为SINGLE_TRANSFER_NO_PWD,biz_scene为MER_TRANS_TO_ACC 或 biz_scene为MER_TRANS_TO_CARD，该值返回
        /// </summary>
        [XmlElement("new_quota_daily_remain")]
        public string NewQuotaDailyRemain { get; set; }

        /// <summary>
        /// 商转新额度单月剩余额度 ，单位为元，精确到小数点后两位；当product_code为SINGLE_TRANSFER_NO_PWD,biz_scene为MER_TRANS_TO_ACC 或 biz_scene为MER_TRANS_TO_CARD，该值返回
        /// </summary>
        [XmlElement("new_quota_monthly_remain")]
        public string NewQuotaMonthlyRemain { get; set; }

        /// <summary>
        /// 商转新额度单笔最大金额，单位为元，精确到小数点后两位；当product_code为SINGLE_TRANSFER_NO_PWD,biz_scene为MER_TRANS_TO_ACC 或 biz_scene为MER_TRANS_TO_CARD，该值返回
        /// </summary>
        [XmlElement("new_quota_single_max")]
        public string NewQuotaSingleMax { get; set; }

        /// <summary>
        /// 商转新额度单笔最小金额，单位为元，精确到小数点后两位；当product_code为SINGLE_TRANSFER_NO_PWD,biz_scene为MER_TRANS_TO_ACC 或 biz_scene为MER_TRANS_TO_CARD，该值返回
        /// </summary>
        [XmlElement("new_quota_single_min")]
        public string NewQuotaSingleMin { get; set; }

        /// <summary>
        /// 对公日可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_corporate_daily_available_amount")]
        public string ToCorporateDailyAvailableAmount { get; set; }

        /// <summary>
        /// 对公月可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_corporate_monthly_available_amount")]
        public string ToCorporateMonthlyAvailableAmount { get; set; }

        /// <summary>
        /// 对私日可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_private_daily_available_amount")]
        public string ToPrivateDailyAvailableAmount { get; set; }

        /// <summary>
        /// 对私月可用额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("to_private_monthly_available_amount")]
        public string ToPrivateMonthlyAvailableAmount { get; set; }
    }
}
