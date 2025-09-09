using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppServiceNotifyUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppServiceNotifyUploadModel : AopObject
    {
        /// <summary>
        /// 账单服务提醒用户信息列表
        /// </summary>
        [XmlArray("bill_service_info")]
        [XmlArrayItem("bill_service_info")]
        public List<BillServiceInfo> BillServiceInfo { get; set; }

        /// <summary>
        /// 省码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 账单服务提醒类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
