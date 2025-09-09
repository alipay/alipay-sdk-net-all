using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityPicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityPicInfo : AopObject
    {
        /// <summary>
        /// 小区的活动娱乐设施图片
        /// </summary>
        [XmlArray("activity_pic_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityPicList { get; set; }

        /// <summary>
        /// 小区大门图片的地址列表
        /// </summary>
        [XmlArray("gate_pic_list")]
        [XmlArrayItem("string")]
        public List<string> GatePicList { get; set; }

        /// <summary>
        /// 小区内部环境图片列表
        /// </summary>
        [XmlArray("inner_env_pic_list")]
        [XmlArrayItem("string")]
        public List<string> InnerEnvPicList { get; set; }

        /// <summary>
        /// 小区的停车设施图片
        /// </summary>
        [XmlArray("parking_pic_list")]
        [XmlArrayItem("string")]
        public List<string> ParkingPicList { get; set; }
    }
}
