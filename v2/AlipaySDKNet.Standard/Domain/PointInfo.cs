using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PointInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PointInfo : AopObject
    {
        /// <summary>
        /// 经营地址
        /// </summary>
        [XmlElement("address")]
        public PointAddressInfo Address { get; set; }

        /// <summary>
        /// 经营时间
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
        /// 联系固定电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 外部点位编号
        /// </summary>
        [XmlElement("out_device_point_id")]
        public string OutDevicePointId { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原类目映射关系参见 <a href="https://gw.alipayobjects.com/os/bmw-prod/4b3f82df-e53e-4b84-bc41-fe025101e726.xlsx">支付宝门店类目-最新</a> 表格。
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
