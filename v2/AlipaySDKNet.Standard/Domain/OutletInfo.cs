using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutletInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutletInfo : AopObject
    {
        /// <summary>
        /// 是否支持商保直付
        /// </summary>
        [XmlElement("insurance_direct_payment")]
        public bool InsuranceDirectPayment { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("outlet_address")]
        public string OutletAddress { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [XmlElement("outlet_code")]
        public string OutletCode { get; set; }

        /// <summary>
        /// 门店距离
        /// </summary>
        [XmlElement("outlet_distance")]
        public string OutletDistance { get; set; }

        /// <summary>
        /// 门店纬度
        /// </summary>
        [XmlElement("outlet_latitude")]
        public string OutletLatitude { get; set; }

        /// <summary>
        /// 门店经度
        /// </summary>
        [XmlElement("outlet_longitude")]
        public string OutletLongitude { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("outlet_name")]
        public string OutletName { get; set; }

        /// <summary>
        /// 门店电话
        /// </summary>
        [XmlElement("outlet_phone")]
        public string OutletPhone { get; set; }

        /// <summary>
        /// 门店服务时间范围
        /// </summary>
        [XmlElement("outlet_time")]
        public string OutletTime { get; set; }
    }
}
