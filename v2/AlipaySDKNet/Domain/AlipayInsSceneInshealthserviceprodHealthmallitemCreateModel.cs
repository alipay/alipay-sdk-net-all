using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodHealthmallitemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodHealthmallitemCreateModel : AopObject
    {
        /// <summary>
        /// 商品录入请求
        /// </summary>
        [XmlElement("item_import_request")]
        public ExternalItemImportRequest ItemImportRequest { get; set; }
    }
}
