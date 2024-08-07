using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsWaybill Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsWaybill : AopObject
    {
        /// <summary>
        /// 用户自行寄件退货时填写的补充描述
        /// </summary>
        [XmlElement("additional_reason")]
        public string AdditionalReason { get; set; }

        /// <summary>
        /// 物流公司编号
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 用户自行寄回商品时，补充上传的证明图片和视频信息
        /// </summary>
        [XmlArray("logistics_media_list")]
        [XmlArrayItem("order_media_info")]
        public List<OrderMediaInfo> LogisticsMediaList { get; set; }

        /// <summary>
        /// 退货寄送方式
        /// </summary>
        [XmlElement("return_delivery_type")]
        public string ReturnDeliveryType { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 物流详情
        /// </summary>
        [XmlArray("steps")]
        [XmlArrayItem("waybill_step")]
        public List<WaybillStep> Steps { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
