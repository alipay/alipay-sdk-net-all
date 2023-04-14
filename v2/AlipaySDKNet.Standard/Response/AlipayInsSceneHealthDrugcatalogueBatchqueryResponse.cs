using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneHealthDrugcatalogueBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneHealthDrugcatalogueBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 药品列表
        /// </summary>
        [XmlArray("drug_item_list")]
        [XmlArrayItem("health_drug_catalogue_item")]
        public List<HealthDrugCatalogueItem> DrugItemList { get; set; }
    }
}
