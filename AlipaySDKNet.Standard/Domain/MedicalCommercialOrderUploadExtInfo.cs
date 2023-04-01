using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalCommercialOrderUploadExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalCommercialOrderUploadExtInfo : AopObject
    {
        /// <summary>
        /// 费用明细
        /// </summary>
        [XmlArray("expense_details")]
        [XmlArrayItem("medical_commercial_order_upload_amount_detail")]
        public List<MedicalCommercialOrderUploadAmountDetail> ExpenseDetails { get; set; }

        /// <summary>
        /// 体检人姓名
        /// </summary>
        [XmlElement("medical_examination_user")]
        public string MedicalExaminationUser { get; set; }

        /// <summary>
        /// 商家小程序appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 当订单状态为“已退款”、“部分退款”时必填，单位为元，不能大于订单金额，精确到小数点后2位
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款说明，商户自定义
        /// </summary>
        [XmlElement("refund_note")]
        public string RefundNote { get; set; }

        /// <summary>
        /// 体检报告链接。当订单状态为“已出报告”时必填
        /// </summary>
        [XmlElement("report_url")]
        public string ReportUrl { get; set; }

        /// <summary>
        /// 门店地址，当订单状态为“使用中”、“已完成”、“已出报告”状态时必填
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店名称，当订单状态为“使用中”、“已完成”、“已出报告”状态时必填
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 核销明细，当订单状态为“使用中”时必填
        /// </summary>
        [XmlArray("write_off_details")]
        [XmlArrayItem("medical_commercial_order_upload_amount_detail")]
        public List<MedicalCommercialOrderUploadAmountDetail> WriteOffDetails { get; set; }
    }
}
