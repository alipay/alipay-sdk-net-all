using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiIsvOpeninfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiIsvOpeninfoModifyModel : AopObject
    {
        /// <summary>
        /// 扩展字段,用于后续其它一些定制化需求.
        /// </summary>
        [XmlElement("ext_info")]
        public FqQrCodeExtendParams ExtInfo { get; set; }

        /// <summary>
        /// 服务商侧的营销活动的对客表达文案.录入后将展示在前置页面上.
        /// </summary>
        [XmlElement("isv_marketing_copy")]
        public string IsvMarketingCopy { get; set; }

        /// <summary>
        /// 商户希望展示的名称.录入后将被展示在前置页面的收款方位置.
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 一次请求的唯一性标识,调用时需要保证在非重试类请求中不重复.
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 二级商户唯一标识
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 店铺的唯一标识,可以不填写.
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
