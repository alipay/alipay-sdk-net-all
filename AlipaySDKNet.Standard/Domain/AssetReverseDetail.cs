using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetReverseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseDetail : AopObject
    {
        /// <summary>
        /// 退货数量
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 取消订单或退货唯一ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 物料状态
        /// </summary>
        [XmlElement("goods_status")]
        public string GoodsStatus { get; set; }

        /// <summary>
        /// 地址是否修改成功标志；取消/退货  不填 地址修改  必填
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
