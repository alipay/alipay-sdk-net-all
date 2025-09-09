using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddHotItemQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddHotItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品对象
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("discount_activity_bean")]
        public List<DiscountActivityBean> ActivityList { get; set; }
    }
}
