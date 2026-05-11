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
        /// 精确到小数点后两位,单位是元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 费用明细
        /// </summary>
        [XmlArray("expense_details")]
        [XmlArrayItem("medical_commercial_order_upload_amount_detail")]
        public List<MedicalCommercialOrderUploadAmountDetail> ExpenseDetails { get; set; }

        /// <summary>
        /// 中医茶饮订单传入商户或服务类型
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 体检人姓名
        /// </summary>
        [XmlElement("medical_examination_user")]
        public string MedicalExaminationUser { get; set; }

        /// <summary>
        /// 商户pid，商品对应主体的pid
        /// </summary>
        [XmlElement("mrch_pid")]
        public string MrchPid { get; set; }

        /// <summary>
        /// 定点医疗机构编码
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 支付时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_way")]
        public string PayWay { get; set; }

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
        /// 场景卡片
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 来源标识
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

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
