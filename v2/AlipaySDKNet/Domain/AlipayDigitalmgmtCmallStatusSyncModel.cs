using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtCmallStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtCmallStatusSyncModel : AopObject
    {
        /// <summary>
        /// goods_data_source，用于商品状态同步，由调用方传入
        /// </summary>
        [XmlElement("goods_data_source")]
        public string GoodsDataSource { get; set; }

        /// <summary>
        /// goods_source_value，用于商品状态同步，由调用方传入
        /// </summary>
        [XmlElement("goods_source_value")]
        public string GoodsSourceValue { get; set; }

        /// <summary>
        /// status，用于商品状态同步，由调用方传入
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
