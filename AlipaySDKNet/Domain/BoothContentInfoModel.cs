using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoothContentInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class BoothContentInfoModel : AopObject
    {
        /// <summary>
        /// 展台名称
        /// </summary>
        [XmlElement("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 内容信息列表
        /// </summary>
        [XmlArray("content_info_list")]
        [XmlArrayItem("content_info_model")]
        public List<ContentInfoModel> ContentInfoList { get; set; }
    }
}
