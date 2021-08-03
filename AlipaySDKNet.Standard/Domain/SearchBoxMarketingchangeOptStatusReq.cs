using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxMarketingchangeOptStatusReq Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxMarketingchangeOptStatusReq : AopObject
    {
        /// <summary>
        /// 需修改至何种状态(支持撤销和删除)
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
