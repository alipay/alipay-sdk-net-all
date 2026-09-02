using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodMallitembatchCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodMallitembatchCreateModel : AopObject
    {
        /// <summary>
        /// 商品批量录入请求
        /// </summary>
        [XmlArray("item_batch_import_request")]
        [XmlArrayItem("external_item_import_request")]
        public List<ExternalItemImportRequest> ItemBatchImportRequest { get; set; }
    }
}
