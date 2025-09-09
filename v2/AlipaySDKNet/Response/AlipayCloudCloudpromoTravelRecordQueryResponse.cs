using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelRecordQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoTravelRecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 沪小游
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("poi_list")]
        [XmlArrayItem("poi_record")]
        public List<PoiRecord> PoiList { get; set; }

        /// <summary>
        /// 分享记录
        /// </summary>
        [XmlElement("share_desc")]
        public string ShareDesc { get; set; }

        /// <summary>
        /// 东方明珠
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
