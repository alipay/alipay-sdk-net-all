using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappBatchqueryModel : AopObject
    {
        /// <summary>
        /// 小程序类型 TINYAPP_TEMPLATE:模板小程序 TINYAPP_NORMAL：普通小程序 TINYAPP_PLUGIN：插件小程序 TINYAPP_WIDGET：小部件
        /// </summary>
        [XmlArray("app_type_list")]
        [XmlArrayItem("string")]
        public List<string> AppTypeList { get; set; }

        /// <summary>
        /// 开放平台开发者ID
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
