using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupmealOpenAuthAddResult Data Structure.
    /// </summary>
    [Serializable]
    public class GroupmealOpenAuthAddResult : AopObject
    {
        /// <summary>
        /// 团餐碰一下签约授权开通结果,true-开通成功；false-开通失败。
        /// </summary>
        [XmlElement("add_openauth_result_status")]
        public bool AddOpenauthResultStatus { get; set; }
    }
}
