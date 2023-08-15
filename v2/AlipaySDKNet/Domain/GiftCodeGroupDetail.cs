using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftCodeGroupDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GiftCodeGroupDetail : AopObject
    {
        /// <summary>
        /// 当前码组关联的所有码详情
        /// </summary>
        [XmlArray("gift_code_detail_list")]
        [XmlArrayItem("gift_code_detail")]
        public List<GiftCodeDetail> GiftCodeDetailList { get; set; }

        /// <summary>
        /// 唯一标识，用来标识唯一一组码
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
