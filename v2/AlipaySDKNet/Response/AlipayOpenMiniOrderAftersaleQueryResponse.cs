using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersaleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderAftersaleQueryResponse : AopResponse
    {
        /// <summary>
        /// 售后单触发类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 创建售后单时用户填写的补充描述
        /// </summary>
        [XmlElement("additional_reason")]
        public string AdditionalReason { get; set; }

        /// <summary>
        /// 退货地址信息
        /// </summary>
        [XmlElement("address_info")]
        public AftersaleAddressInfoVO AddressInfo { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("aftersale_goods_info_list")]
        [XmlArrayItem("aftersale_item_info")]
        public List<AftersaleItemInfo> AftersaleGoodsInfoList { get; set; }

        /// <summary>
        /// 平台售后单号
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 用户通过标准售后组件申请售后时，上传的证明图片和视频信息
        /// </summary>
        [XmlArray("aftersale_media_list")]
        [XmlArrayItem("order_media_info")]
        public List<OrderMediaInfo> AftersaleMediaList { get; set; }

        /// <summary>
        /// 用户售后发起原因
        /// </summary>
        [XmlElement("aftersale_reason")]
        public string AftersaleReason { get; set; }

        /// <summary>
        /// 申请退款金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("apply_refund_amount")]
        public string ApplyRefundAmount { get; set; }

        /// <summary>
        /// 创建时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最终退款金额，单位：元,精确到小数点后两位
        /// </summary>
        [XmlElement("finally_refund_amount")]
        public string FinallyRefundAmount { get; set; }

        /// <summary>
        /// 物流单详情
        /// </summary>
        [XmlArray("logistics_waybills")]
        [XmlArrayItem("logistics_waybill")]
        public List<LogisticsWaybill> LogisticsWaybills { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 商家小程序售后单页面
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 售后服务标签列表，该笔售后单享有哪些需要关注的售后保障服务。
        /// </summary>
        [XmlArray("service_tag_list")]
        [XmlArrayItem("aftersale_service_tag")]
        public List<AftersaleServiceTag> ServiceTagList { get; set; }

        /// <summary>
        /// 售后单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 售后单状态code
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
