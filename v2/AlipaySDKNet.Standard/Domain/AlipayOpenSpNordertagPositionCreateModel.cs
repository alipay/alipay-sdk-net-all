using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordertagPositionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordertagPositionCreateModel : AopObject
    {
        /// <summary>
        /// 详细地址，如果省市区为空，则这里必须带有省市区信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 所在城市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 详细地址所在区县
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 点位的品牌、场景、场所信息
        /// </summary>
        [XmlElement("ext_info")]
        public NorderTagPositionExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 对点位进行的操作
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 点位标识，更新点位信息时必填，取值方式：创建点位时候返回
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 省份中文名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("tag_position_name")]
        public string TagPositionName { get; set; }
    }
}
