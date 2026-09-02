using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNfcexpoprodOrderdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNfcexpoprodOrderdetailQueryModel : AopObject
    {
        /// <summary>
        /// 物料编号
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务唯一编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
