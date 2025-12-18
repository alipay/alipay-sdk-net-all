using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpSubOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpSubOrderInfo : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 一体化作业商户门店信息
        /// </summary>
        [XmlArray("shop_infos")]
        [XmlArrayItem("inte_op_shop_info_v_o")]
        public List<InteOpShopInfoVO> ShopInfos { get; set; }

        /// <summary>
        /// 一体化作业子项单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }

        /// <summary>
        /// 一体化作业子项状态
        /// </summary>
        [XmlElement("sub_order_status")]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 一体化作业子项类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
