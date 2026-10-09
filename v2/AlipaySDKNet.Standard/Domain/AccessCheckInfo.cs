using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessCheckInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AccessCheckInfo : AopObject
    {
        /// <summary>
        /// 校验结果
        /// </summary>
        [XmlElement("access_check")]
        public bool AccessCheck { get; set; }

        /// <summary>
        /// 每一项规则校验结果
        /// </summary>
        [XmlArray("check_item_info_list")]
        [XmlArrayItem("access_check_item_info")]
        public List<AccessCheckItemInfo> CheckItemInfoList { get; set; }
    }
}
