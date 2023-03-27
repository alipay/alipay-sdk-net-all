using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollContent Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollContent : AopObject
    {
        /// <summary>
        /// 报名提交的小程序商品列表。
        /// </summary>
        [XmlArray("app_items")]
        [XmlArrayItem("recruit_content_app_item")]
        public List<RecruitContentAppItem> AppItems { get; set; }
    }
}
