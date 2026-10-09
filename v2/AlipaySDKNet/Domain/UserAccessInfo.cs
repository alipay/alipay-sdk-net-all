using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserAccessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserAccessInfo : AopObject
    {
        /// <summary>
        /// 人传人短信用户查询手机号
        /// </summary>
        [XmlElement("tel_num")]
        public string TelNum { get; set; }

        /// <summary>
        /// 用户圈选信息
        /// </summary>
        [XmlArray("user_segmentation_info")]
        [XmlArrayItem("user_segmentation_info")]
        public List<UserSegmentationInfo> UserSegmentationInfo { get; set; }
    }
}
