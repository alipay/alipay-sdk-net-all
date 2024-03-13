using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiIsvOpeninfoModifyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiIsvOpeninfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 声明了本响应数据的用途.仅做说明使用,调用方无需消费.
        /// </summary>
        [XmlElement("disclaimer")]
        public string Disclaimer { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public FqQrCodeExtendParams ExtInfo { get; set; }

        /// <summary>
        /// 服务商侧的营销活动的对客表达文案.与请求中isv_marketing_copy字段值一致.
        /// </summary>
        [XmlElement("isv_marketing_copy")]
        public string IsvMarketingCopy { get; set; }

        /// <summary>
        /// 商户名称.与请求中的merchant_name字段值一致.
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 外部请求号,取自请求中的同名字段,用来标识当前结果对应哪个写入/查询请求.
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 二级商户唯一标识.标识了本响应中的相关信息对应了哪个二级商户.
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 店铺的唯一标识.与请求中的同名参数相对应,如果没有店铺编号则为空.
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
