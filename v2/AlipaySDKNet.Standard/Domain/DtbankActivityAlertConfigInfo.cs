using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtbankActivityAlertConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtbankActivityAlertConfigInfo : AopObject
    {
        /// <summary>
        /// 总剩余预算预警值，单位：分
        /// </summary>
        [XmlElement("alert_value")]
        public long AlertValue { get; set; }

        /// <summary>
        /// 接口通知应用APPID
        /// </summary>
        [XmlArray("app_id_list")]
        [XmlArrayItem("string")]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// 预警方式：MESSAGE：短信；INTERFACE：接口
        /// </summary>
        [XmlElement("budget_alert_notify_type")]
        public string BudgetAlertNotifyType { get; set; }

        /// <summary>
        /// 短信通知联系人列表
        /// </summary>
        [XmlArray("phone_no_list")]
        [XmlArrayItem("string")]
        public List<string> PhoneNoList { get; set; }

        /// <summary>
        /// 配置的核销速率预警值，单位：分
        /// </summary>
        [XmlElement("write_off_rate_alert_value")]
        public long WriteOffRateAlertValue { get; set; }
    }
}
