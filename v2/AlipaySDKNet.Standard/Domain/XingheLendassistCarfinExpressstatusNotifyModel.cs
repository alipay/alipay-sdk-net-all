using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinExpressstatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinExpressstatusNotifyModel : AopObject
    {
        /// <summary>
        /// 快递异常原因
        /// </summary>
        [XmlElement("alert_reason")]
        public string AlertReason { get; set; }

        /// <summary>
        /// 快递员信息
        /// </summary>
        [XmlElement("courier_info")]
        public CarfinCourier CourierInfo { get; set; }

        /// <summary>
        /// 预计送达时间
        /// </summary>
        [XmlElement("estimated_delivery_date")]
        public string EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// 星河侧快递订单号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 快递服务商回传文件使用
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("carfin_express_file")]
        public List<CarfinExpressFile> FileList { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 外部快递订单号
        /// </summary>
        [XmlElement("out_express_no")]
        public string OutExpressNo { get; set; }

        /// <summary>
        /// 快递状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
