using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwItemSyncModel : AopObject
    {
        /// <summary>
        /// 云客服平台的事项库id
        /// </summary>
        [XmlElement("library_id")]
        public string LibraryId { get; set; }

        /// <summary>
        /// 具体的事项列表
        /// </summary>
        [XmlElement("lists")]
        public ItemGwDTO Lists { get; set; }

        /// <summary>
        /// 同步操作的id,  外部透传，便于记录与问题排查
        /// </summary>
        [XmlElement("syn_id")]
        public string SynId { get; set; }
    }
}
