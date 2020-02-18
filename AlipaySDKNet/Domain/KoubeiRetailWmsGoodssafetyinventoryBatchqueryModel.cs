using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodssafetyinventoryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 货品编码，限制最大查询数量1000
        /// </summary>
        [XmlArray("goods_codes")]
        [XmlArrayItem("string")]
        public List<string> GoodsCodes { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
