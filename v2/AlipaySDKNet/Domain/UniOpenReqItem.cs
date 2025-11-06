using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UniOpenReqItem Data Structure.
    /// </summary>
    [Serializable]
    public class UniOpenReqItem : AopObject
    {
        /// <summary>
        /// 聚合开通详情
        /// </summary>
        [XmlElement("detail_infos")]
        public UniOpenReqItemDetailInfos DetailInfos { get; set; }

        /// <summary>
        /// 开通类型
        /// </summary>
        [XmlElement("open_type")]
        public string OpenType { get; set; }
    }
}
