using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppinfoMultiBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAppinfoMultiBatchqueryModel : AopObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 应用id列表参数，比如[2017010362788004,2017010362788005]
        /// </summary>
        [XmlArray("mini_app_id_list")]
        [XmlArrayItem("string")]
        public List<string> MiniAppIdList { get; set; }
    }
}
