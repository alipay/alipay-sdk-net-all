using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppBillNotifyUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppBillNotifyUploadModel : AopObject
    {
        /// <summary>
        /// 账单提醒用户信息
        /// </summary>
        [XmlArray("bill_notify_info")]
        [XmlArrayItem("bill_notify_info")]
        public List<BillNotifyInfo> BillNotifyInfo { get; set; }

        /// <summary>
        /// 省码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 账单提醒类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
