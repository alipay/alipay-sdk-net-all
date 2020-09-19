using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAntdaoMypointsPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceAntdaoMypointsPublishModel : AopObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 方法路由
        /// </summary>
        [XmlElement("method_name")]
        public string MethodName { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
