using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotManufacturerUrlModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotManufacturerUrlModifyModel : AopObject
    {
        /// <summary>
        /// 模块变更详情
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("tag_url_modify_info")]
        public List<TagUrlModifyInfo> Items { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
