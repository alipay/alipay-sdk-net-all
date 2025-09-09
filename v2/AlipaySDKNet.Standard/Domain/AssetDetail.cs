using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDetail : AopObject
    {
        /// <summary>
        /// APPLET_ASSET
        /// </summary>
        [XmlElement("asset")]
        public string Asset { get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [XmlElement("asset_name")]
        public string AssetName { get; set; }

        /// <summary>
        /// 转化分层基础信息列表
        /// </summary>
        [XmlArray("converted_event_grp_detail_list")]
        [XmlArrayItem("converted_event_grp_detail")]
        public List<ConvertedEventGrpDetail> ConvertedEventGrpDetailList { get; set; }
    }
}
