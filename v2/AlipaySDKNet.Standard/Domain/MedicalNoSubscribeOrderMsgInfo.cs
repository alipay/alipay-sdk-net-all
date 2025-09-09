using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalNoSubscribeOrderMsgInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalNoSubscribeOrderMsgInfo : AopObject
    {
        /// <summary>
        /// 检查项目
        /// </summary>
        [XmlElement("check_item")]
        public string CheckItem { get; set; }

        /// <summary>
        /// 实际检查时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 检查时间段
        /// </summary>
        [XmlElement("check_time_slot")]
        public string CheckTimeSlot { get; set; }

        /// <summary>
        /// 当前叫号
        /// </summary>
        [XmlElement("current_num")]
        public string CurrentNum { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 科室为准
        /// </summary>
        [XmlElement("dept_loc")]
        public string DeptLoc { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital")]
        public string Hospital { get; set; }

        /// <summary>
        /// 就诊序号
        /// </summary>
        [XmlElement("medical_num")]
        public string MedicalNum { get; set; }

        /// <summary>
        /// 订单详情链接，三方小程序的服务直达链接
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 调用方自定义浮层链接
        /// </summary>
        [XmlElement("msg_popup_url")]
        public string MsgPopupUrl { get; set; }

        /// <summary>
        /// 就诊人
        /// </summary>
        [XmlElement("patient")]
        public string Patient { get; set; }

        /// <summary>
        /// 订单实际支付金额（元，两位小数）
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单实际退款金额（元，两位小数）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        [XmlElement("scheduled_time")]
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 预约时段
        /// </summary>
        [XmlElement("scheduled_time_slot")]
        public string ScheduledTimeSlot { get; set; }

        /// <summary>
        /// 温馨提示，文本类型，最长200个中文字
        /// </summary>
        [XmlElement("summary_tip")]
        public string SummaryTip { get; set; }

        /// <summary>
        /// 订单待支付金额（元，两位小数）
        /// </summary>
        [XmlElement("wait_pay_amount")]
        public string WaitPayAmount { get; set; }
    }
}
