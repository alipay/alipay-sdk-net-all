using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOrdermemoSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOrdermemoSetModel : AopObject
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("axf_order_memo_info")]
        public AxfOrderMemoInfo AxfOrderMemoInfo { get; set; }

        /// <summary>
        /// 售卖订单ID。即需要添加备注的订单
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 操作类型。表示此次操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }
    }
}
