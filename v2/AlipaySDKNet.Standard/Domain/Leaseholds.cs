using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Leaseholds Data Structure.
    /// </summary>
    [Serializable]
    public class Leaseholds : AopObject
    {
        /// <summary>
        /// 日租单价，按元/台/天填写
        /// </summary>
        [XmlElement("daily_rent_price")]
        public string DailyRentPrice { get; set; }

        /// <summary>
        /// 设备型号，根据租赁设备型号填写
        /// </summary>
        [XmlElement("device_model_no")]
        public string DeviceModelNo { get; set; }

        /// <summary>
        /// 预计租赁数量
        /// </summary>
        [XmlElement("expected_lease_quantity")]
        public string ExpectedLeaseQuantity { get; set; }

        /// <summary>
        /// 租赁资产ID，框架租赁合同可不填，若有多个则以数组形式上传
        /// </summary>
        [XmlArray("lease_asset_ids")]
        [XmlArrayItem("string")]
        public List<string> LeaseAssetIds { get; set; }

        /// <summary>
        /// 月租单价，按元/台/月填写
        /// </summary>
        [XmlElement("month_rent_price")]
        public string MonthRentPrice { get; set; }
    }
}
