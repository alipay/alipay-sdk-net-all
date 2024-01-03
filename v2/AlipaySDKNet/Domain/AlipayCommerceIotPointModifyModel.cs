using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotPointModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotPointModifyModel : AopObject
    {
        /// <summary>
        /// 经营地址
        /// </summary>
        [XmlElement("address")]
        public PointAddressInfo Address { get; set; }

        /// <summary>
        /// 点位经营时间
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("point_business_time")]
        public List<PointBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 联系手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 固定联系电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 外部点位ID
        /// </summary>
        [XmlElement("out_device_point_id")]
        public string OutDevicePointId { get; set; }

        /// <summary>
        /// 经营类目
        /// </summary>
        [XmlElement("point_category_code")]
        public string PointCategoryCode { get; set; }

        /// <summary>
        /// 点位分组
        /// </summary>
        [XmlElement("point_group")]
        public string PointGroup { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("point_name")]
        public string PointName { get; set; }
    }
}
