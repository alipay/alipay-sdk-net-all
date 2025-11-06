using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopOpauthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopOpauthCreateModel : AopObject
    {
        /// <summary>
        /// 业务开通主单号，用于一体化作业过程的申请单串联
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 授权产品信息
        /// </summary>
        [XmlArray("inteop_product_info")]
        [XmlArrayItem("inteop_op_auth_product_info")]
        public List<InteopOpAuthProductInfo> InteopProductInfo { get; set; }
    }
}
