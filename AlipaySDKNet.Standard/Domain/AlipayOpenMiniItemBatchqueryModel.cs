using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 操作类型，固定为：ITEM_BATCHQUERY
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 支付宝平台侧商品 id 列表，最多20个。通过商品信息导入返回的result_data，商品信息导入流程详见 <a href="https://opendocs.alipay.com/mini/00nxao#%E5%95%86%E5%93%81%E4%BF%A1%E6%81%AF%E5%AF%BC%E5%85%A5">导入商品</a>。
        /// </summary>
        [XmlArray("platform_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> PlatformItemIdList { get; set; }
    }
}
