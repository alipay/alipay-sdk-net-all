using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupmealOpenAuthCancelResult Data Structure.
    /// </summary>
    [Serializable]
    public class GroupmealOpenAuthCancelResult : AopObject
    {
        /// <summary>
        /// 团餐碰一下批量解约授权结果,true-解约成功；false-解约失败。
        /// </summary>
        [XmlElement("cancel_openauth_result_status")]
        public bool CancelOpenauthResultStatus { get; set; }
    }
}
