using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsCheckPostpolicyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsCheckPostpolicyQueryModel : AopObject
    {
        /// <summary>
        /// app_id_list是名下需要验收的小程序id列表，可从O站获取
        /// </summary>
        [XmlArray("app_id_list")]
        [XmlArrayItem("string")]
        public List<string> AppIdList { get; set; }
    }
}
