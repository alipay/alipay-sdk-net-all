using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOctokenAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOctokenAuthQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授权完成后回跳ISV页面地址
        /// </summary>
        [XmlElement("call_url")]
        public string CallUrl { get; set; }

        /// <summary>
        /// 渠道信息(由支付宝分配)
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 线上业务类型编码
        /// </summary>
        [XmlElement("ol_biz_type_code")]
        public string OlBizTypeCode { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 定点医药机构编码
        /// </summary>
        [XmlElement("org_cfc_id")]
        public string OrgCfcId { get; set; }

        /// <summary>
        /// 机构渠道认证编码
        /// </summary>
        [XmlElement("org_chnl_crtf_code")]
        public string OrgChnlCrtfCode { get; set; }

        /// <summary>
        /// 合作伙伴所在城市编码(国标)
        /// </summary>
        [XmlElement("partner_city_code")]
        public string PartnerCityCode { get; set; }

        /// <summary>
        /// 合作伙伴Id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// ISV请求业务唯一流水号
        /// </summary>
        [XmlElement("req_biz_no")]
        public string ReqBizNo { get; set; }

        /// <summary>
        /// 订单总金额(单位: 元)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
