using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyPointSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyPointSaveModel : AopObject
    {
        /// <summary>
        /// 执行动作 新增：ADD 更新：UPDATE
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("device_ids")]
        [XmlArrayItem("string")]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// 所在楼层
        /// </summary>
        [XmlElement("floor_num")]
        public long FloorNum { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("job_ids")]
        [XmlArrayItem("string")]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 点位描述
        /// </summary>
        [XmlElement("location_desc")]
        public string LocationDesc { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 新增时非必填，更新时与外部点位id二选一
        /// </summary>
        [XmlElement("location_point_id")]
        public string LocationPointId { get; set; }

        /// <summary>
        /// 点位类型 巡检：PATROL 门禁：EC
        /// </summary>
        [XmlElement("location_type")]
        public string LocationType { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 是否多层 是：Y 否：N（默认）
        /// </summary>
        [XmlElement("muti_floor")]
        public string MutiFloor { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_device_ids")]
        [XmlArrayItem("string")]
        public List<string> OutDeviceIds { get; set; }

        /// <summary>
        /// 新增时必填，更新时与点位id二选一
        /// </summary>
        [XmlElement("out_location_point_id")]
        public string OutLocationPointId { get; set; }

        /// <summary>
        /// 新增不传入。需要解绑线圈时，在更新时可以传入，解绑成功返回
        /// </summary>
        [XmlElement("unbind_card")]
        public bool UnbindCard { get; set; }
    }
}
